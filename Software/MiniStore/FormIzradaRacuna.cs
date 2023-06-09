﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidacijaUnosa;

namespace MiniStore
{
    public partial class FormIzradaRacuna : Form
    {
        public int TrgovinaId { get; set; }
        public int SkladisteId { get; set; }

        List<RacunArtikl> artikli = new List<RacunArtikl>();
        List<Artikl> sviArtikli = new List<Artikl>();

        public FormIzradaRacuna()
        {
            InitializeComponent();
        }

        private void tbSifraArtikla_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            if (tbSifraArtikla.Text.Length > 0 && !Validator.ProvjeriSifruArtikla(tbSifraArtikla.Text))
            {
                MessageBox.Show("Šifra artikla nije u ispravnom formatu! Dozvoljeni su samo brojevi.");
                return;
            }

            int kolicina = 1;

            var unesenaKolicina = tbKolicina.Text;
            if (unesenaKolicina.Length > 0)
            {
                kolicina = int.Parse(tbKolicina.Text);
            }

            if (tbSifraArtikla.Text.Length < 1)
            {
                MessageBox.Show("Unesite šifru artikla!");
                return;
            }

            int sifraArtikla = int.Parse(tbSifraArtikla.Text);

            Artikl trenutniArtikl;
            decimal trenutniArtiklCijena;
            using (var db = new Database())
            {
                trenutniArtikl = sviArtikli.FirstOrDefault(a => a.id == sifraArtikla);
            }

            if (trenutniArtikl == null)
            {
                MessageBox.Show("Artikl s tom šifrom ne postoji ili nije dostupan u ovoj poslovnici!");
                return;
            }

            using (var db = new Database())
            {
                trenutniArtiklCijena = db.Artikls.Include("ArtiklCijenas").First(a => a.id == trenutniArtikl.id).ArtiklCijenas.OrderBy(c => c.vrijediOd).First().cijena;
            }

            Console.Beep(860, 350);

            if (artikli.Count(a => a.artiklId == sifraArtikla) > 0)
            {
                artikli.First(a => a.artiklId == sifraArtikla).kolicina += kolicina;
            }
            else
            {
                artikli.Add(new RacunArtikl
                {
                    artiklId = sifraArtikla,
                    kolicina = kolicina,
                    cijena = trenutniArtiklCijena,
                });
            }

            tbKolicina.Clear();
            tbSifraArtikla.Clear();

            OsvjeziDgv();


        }

        void OsvjeziDgv()
        {
            dgvStavkeRacuna.DataSource = artikli.Select(a => new
            {
                Naziv = sviArtikli.First(r => r.id == a.artiklId).naziv,
                Kolicina = a.kolicina,
                Cijena = $"{a.cijena:C2}",
                PDV = "25%",
                Iznos = $"{((decimal)1.25 * a.cijena * a.kolicina):C2}",
            }).ToList();

            var iznos = artikli.Sum(a => (decimal)1.25 * a.cijena * a.kolicina);

            lblIznos.Text = $"{iznos:C2}";

            if (artikli.Count > 0)
            {
                btnUkloni.Enabled = true;
            }
            else
            {
                btnUkloni.Enabled = false;
            }
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            if (lbNacinPlacanja.SelectedIndex == -1)
            {
                MessageBox.Show("Način plaćanja nije odabran!");
                return;
            }

            if (artikli.Count < 1)
            {
                MessageBox.Show("Račun ne sadrži niti jedan artikl!");
                return;
            }

            var iznos = artikli.Sum(a => (decimal)1.25 * a.cijena * a.kolicina);

            var racun = new Racun()
            {
                datumVrijeme = DateTime.Now,
                iznos = iznos,
                korisnikId = 1,
                trgovinaId = TrgovinaId,
                nacinPlacanja = lbNacinPlacanja.SelectedItem.ToString(),
            };

            using (var db = new Database())
            {
                db.Racuns.Add(racun);
                db.SaveChanges();

                foreach (var stavka in artikli)
                {
                    stavka.racunId = racun.id;
                }

                racun.RacunArtikls = artikli;

                db.SaveChanges();


            }

            var rezultat = MessageBox.Show("Račun generiran! Želite li prikazati račun?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                FormIzradaRacunaIzvjestaj f = new FormIzradaRacunaIzvjestaj();
                using (var db = new Database())
                {
                    var trenutnaTrgovina = db.Trgovinas.Include("Lokacija").First(t => t.id == TrgovinaId);
                    var trenutniKorisnik = db.Korisniks.First(k => k.id == 1);
                    f.Podaci = new RacunIzvjestaj
                    {
                        SifraRacuna =racun.id,
                        NacinPlacanja= racun.nacinPlacanja,
                        
                        NazivTrgovine = trenutnaTrgovina.oznaka,
                        AdresaTrgovine = trenutnaTrgovina.Lokacija.adresa + "\n" + trenutnaTrgovina.Lokacija.Grad.naziv,
                        Datum = racun.datumVrijeme,
                        Blagajnik = trenutniKorisnik.ime + " " + trenutniKorisnik.prezime,
                        Stavke = artikli.Select(s =>
                        {
                            var trenutniArtikl = db.Artikls.First(a => a.id == s.artiklId);
                            return new RacunIzvjestajStavka
                            {
                                Sifra = s.artiklId,
                                Naziv = trenutniArtikl.naziv,
                                Kolicina = s.kolicina,
                                Cijena = s.cijena,
                                PDV = "25%",
                                Iznos = s.kolicina * s.cijena * (decimal)1.25,
                            };
                        }).ToList(),

                    };

                }

                f.ShowDialog();
            }

            using (var db = new Database())
            {
                foreach (var artikl in artikli)
                {
                    var trenutniArtikl = db.Artikls.Include("ArtiklSkladistes").First(p => p.id == artikl.artiklId);
                    var trenutnoSkladiste = trenutniArtikl.ArtiklSkladistes.First(s => s.skaldisteId == SkladisteId);
                    trenutnoSkladiste.kolicina -= artikl.kolicina;
                }

                db.SaveChanges();
            }


            Close();
        }

        private void FormIzradaRacuna_Load(object sender, EventArgs e)
        {
            using (var db = new Database())
            {
                var skladisteTrenutneTrgovine = db.Trgovinas.Include("Skladistes").First(t => t.id == TrgovinaId).Skladistes.First();
                SkladisteId = skladisteTrenutneTrgovine.id;
                sviArtikli = skladisteTrenutneTrgovine.ArtiklSkladistes.Select(s => s.Artikl).ToList();
            }

            // Unaprijed odaberi prvi nacin placanja.
            lbNacinPlacanja.SelectedIndex = 0;
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            FormStorniranjeRacuna f = new FormStorniranjeRacuna();
            f.TrgovinaId = TrgovinaId;
            f.SkladisteId = SkladisteId;
            f.ShowDialog();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (dgvStavkeRacuna.CurrentRow.Index == -1 || artikli.Count < 1)
            {
                MessageBox.Show("Odaberite zapis za uklanjanje!");
                return;
            }
            artikli.RemoveAt(dgvStavkeRacuna.CurrentRow.Index);
            OsvjeziDgv();
        }
    }
}
