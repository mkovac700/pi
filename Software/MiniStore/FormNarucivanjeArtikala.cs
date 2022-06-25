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
    public partial class FormNarucivanjeArtikala : Form
    {
        public int TrgovinaId { get; set; }
        List<Artikl> artikli = new List<Artikl>();
        List<ArtiklNarudzbenica> stavkeNarudzbenice = new List<ArtiklNarudzbenica>();
        public FormNarucivanjeArtikala()
        {
            InitializeComponent();
        }

        private void FormNarucivanjeArtikala_Load(object sender, EventArgs e)
        {

            using (var db = new Database())
            {
                cbDobavljac.DataSource = db.Dobavljacs.ToList();
                cbDobavljac.DisplayMember = "naziv";
            }
        }

        private void cbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trenutniDobavljac = cbDobavljac.SelectedItem as Dobavljac;
            using (var db = new Database())
            {
                artikli = db.Artikls.Where(p => p.dobavljacId == trenutniDobavljac.id).ToList();
            }
            dgvPopisArtikala.DataSource = artikli;

        }

        private void tbSIfraArtika_TextChanged(object sender, EventArgs e)
        {
            if (tbSifraArtikla.Text.Length > 0)
            {
                dgvPopisArtikala.DataSource = artikli.Where(p => p.id.ToString().Contains(tbSifraArtikla.Text)).ToList();
            }
            else
            {
                dgvPopisArtikala.DataSource = artikli;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            cbDobavljac.Enabled = false;

            var odabraniArtikl = dgvPopisArtikala.CurrentRow.DataBoundItem as Artikl;
            int kolicina = (int)nudKolicina.Value;
            if (kolicina < 1)
            {
                MessageBox.Show("Količina nije ispravna!");
                return;
            }

            if (stavkeNarudzbenice.Count(s => s.artiklId == odabraniArtikl.id) > 0)
            {
                stavkeNarudzbenice.First(s => s.artiklId == odabraniArtikl.id).kolicina += kolicina;
            }
            else
            {
                stavkeNarudzbenice.Add(new ArtiklNarudzbenica
                {
                    artiklId = odabraniArtikl.id,
                    kolicina = kolicina,
                });
            }

            OsvjeziDgvStavke();
            nudKolicina.Value = 0;
            tbSifraArtikla.Clear();

        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            stavkeNarudzbenice.RemoveAt(dgvStavkeNarudzbenice.CurrentRow.Index);
            OsvjeziDgvStavke();

            if (stavkeNarudzbenice.Count < 1)
            {
                cbDobavljac.Enabled = true;
            }
            else
            {
                cbDobavljac.Enabled = false;
            }
        }

        void OsvjeziDgvStavke()
        {
            using (var db = new Database())
            {

                dgvStavkeNarudzbenice.DataSource = stavkeNarudzbenice.Select(p =>
                {
                    var trenutniArtikl = db.Artikls.First(a => a.id == p.artiklId);
                    return new
                    {
                        Artikl = trenutniArtikl.naziv,
                        Kolicina = p.kolicina,
                        Dobavljac = db.Dobavljacs.First(d => d.id == trenutniArtikl.dobavljacId).naziv,
                    };
                }).ToList();

            }
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            var narudzbenica = new Narudzbenica
            {
                datumVrijeme = DateTime.Now,
                dobavljacId = (cbDobavljac.SelectedItem as Dobavljac).id,
                korisnikId = 1,
                trgovinaId = TrgovinaId,
            };

            using (var db = new Database())
            {
                db.Narudzbenicas.Add(narudzbenica);
                db.SaveChanges();

                foreach (var stavka in stavkeNarudzbenice)
                {
                    stavka.narudzbenicaId = narudzbenica.id;
                }

                narudzbenica.ArtiklNarudzbenicas = stavkeNarudzbenice;

                db.SaveChanges();
            }

            var rezultat = MessageBox.Show("Narudžbenica generirana! Želite li prikazati izvještaj?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                FormNarucivanjeArtikalaIzvjestaj f = new FormNarucivanjeArtikalaIzvjestaj();
                using (var db = new Database())
                {
                    var trenutnaTrgovina = db.Trgovinas.Include("Lokacija").First(t => t.id == TrgovinaId);
                    var trenutniDobavljac = cbDobavljac.SelectedItem as Dobavljac;
                    var trenutniKorisnik = db.Korisniks.First(k => k.id == 1);
                    f.Podaci = new NarudzbenicaIzvjestaj
                    {
                        NazivTrgovine = trenutnaTrgovina.oznaka,
                        AdresaTrgovine = trenutnaTrgovina.Lokacija.adresa + "\n" + trenutnaTrgovina.Lokacija.Grad.naziv,
                        NazivDobavljaca = trenutniDobavljac.naziv,
                        AdresaDobavljaca = trenutniDobavljac.adresa,
                        DatumNarudzbenice = narudzbenica.datumVrijeme,
                        ImeKorisnika = trenutniKorisnik.ime + " " + trenutniKorisnik.prezime,
                        Artikli = stavkeNarudzbenice.Select(s =>
                        {
                            var trenutniArtikl = db.Artikls.First(a => a.id == s.artiklId);
                            return new NarudzbenicaIzvjestajStavka
                            {
                                NazivArtikla = trenutniArtikl.naziv,
                                Kolicina = s.kolicina,

                            };
                        }).ToList(),



                    };

                }


                f.ShowDialog();
            }

            Close();
        }
    }
}
