using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class FormIzradaRacuna : Form
    {
        public int TrgovinaId { get; set; }

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
            using (var db = new Database())
            {
                trenutniArtikl = db.Artikls.Include("ArtiklCijenas").FirstOrDefault(a => a.id == sifraArtikla);
            }

            if (trenutniArtikl == null)
            {
                MessageBox.Show("Artikl s tom šifrom ne postoji!");
                return;
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
                    cijena = trenutniArtikl.ArtiklCijenas.OrderBy(c => c.vrijediOd).First().cijena,
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
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            if (lbNacinPlacanja.SelectedIndex == -1) {
                MessageBox.Show("Način plaćanja nije odabran!");
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
                                Iznos = s.kolicina*s.cijena*(decimal)1.25


                            };
                        }).ToList(),



                    };

                }


                f.ShowDialog();
            }
        }

        private void FormIzradaRacuna_Load(object sender, EventArgs e)
        {
            using (var db = new Database())
            {
                sviArtikli = db.Artikls.ToList();
            }
        }
    }
}
