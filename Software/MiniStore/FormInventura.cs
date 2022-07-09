using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidacijaLib;

namespace MiniStore
{
    public partial class FormInventura : Form
    {
        Database entities = new Database();

        List<ArtiklInventura> artikliInventuraList = new List<ArtiklInventura>();

        Inventura novaInventura;

        private int idSkladiste;
        private int idTrgovina;
        private int idKorisnik;

        private int primkaKolicina = 0;
        private decimal primkaCijena = 0;
        private int povratnicaKolicina = 0;
        private decimal povratnicaCijena = 0;
        private int racunKolicina = 0;
        private decimal racunCijena = 0;

        private int racunovodstvenaKolicina = 0;
        private decimal racunovodstvenaCijena = 0;
        private int stvarnaKolicina = 0;
        private decimal stvarnaCijena = 0;
        private decimal inventurnaRazlika = 0;

        public FormInventura()
        {
            InitializeComponent();
        }
        private void FormInventura_Load(object sender, EventArgs e)
        {
            idSkladiste = Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault().Skladistes.FirstOrDefault().id;
            idTrgovina = Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault().id;
            idKorisnik = Autentifikator.DohvatiPrijavljenogKorisnika().id;

            entities.Artikls.Load();
            entities.ArtiklSkladistes.Load();

            lblStatus.Text = "";
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            entities.ArtiklPrimkas.Load();
            entities.RacunArtikls.Load();
            entities.ArtiklPovratnicas.Load();

            var kolicinaPrimka = from primka in entities.ArtiklPrimkas.Local
                                 where primka.zaprimljeno == 1
                                 && primka.Primka.datumVrijeme >= dtpDatumInventure.Value.AddYears(-1)
                                 && primka.Primka.datumVrijeme <= dtpDatumInventure.Value
                                 && primka.skladisteId == idSkladiste
                                 select primka.kolicina;
            var cijenaPrimka = from primka in entities.ArtiklPrimkas.Local
                               where primka.zaprimljeno == 1
                               && primka.Primka.datumVrijeme >= dtpDatumInventure.Value.AddYears(-1)
                               && primka.Primka.datumVrijeme <= dtpDatumInventure.Value
                               && primka.skladisteId == idSkladiste
                               select primka.cijena * primka.kolicina;

            var kolicinaRacun = from racun in entities.RacunArtikls.Local
                                where racun.Racun.datumVrijeme >= dtpDatumInventure.Value.AddYears(-1)
                                && racun.Racun.datumVrijeme <= dtpDatumInventure.Value
                                && racun.Racun.trgovinaId == idTrgovina
                                select racun.kolicina;
            var cijenaRacun = from racun in entities.RacunArtikls.Local
                              where racun.Racun.datumVrijeme >= dtpDatumInventure.Value.AddYears(-1)
                              && racun.Racun.datumVrijeme <= dtpDatumInventure.Value
                              && racun.Racun.trgovinaId == idTrgovina
                              select racun.cijena * racun.kolicina;

            var kolicinaPovratnica = from povratnica in entities.ArtiklPovratnicas.Local
                                     where povratnica.Povratnica.datumVrijeme >= dtpDatumInventure.Value.AddYears(-1)
                                     && povratnica.Povratnica.datumVrijeme <= dtpDatumInventure.Value
                                     && povratnica.Povratnica.trgovinaId == idTrgovina
                                     select povratnica.kolicina;
            var cijenaPovratnica = from povratnica in entities.ArtiklPovratnicas.Local
                                   where povratnica.Povratnica.datumVrijeme >= dtpDatumInventure.Value.AddYears(-1)
                                   && povratnica.Povratnica.datumVrijeme <= dtpDatumInventure.Value
                                   && povratnica.Povratnica.trgovinaId == idTrgovina
                                   select povratnica.cijena * povratnica.kolicina;

            primkaKolicina = (int)kolicinaPrimka.Sum();
            primkaCijena = (decimal)cijenaPrimka.Sum();

            racunKolicina = (int)kolicinaRacun.Sum();
            racunCijena = (decimal)cijenaRacun.Sum();

            povratnicaKolicina = (int)kolicinaPovratnica.Sum();
            povratnicaCijena = (decimal)cijenaPovratnica.Sum();

            racunovodstvenaKolicina = primkaKolicina - racunKolicina - povratnicaKolicina;
            racunovodstvenaCijena = primkaCijena - racunCijena - povratnicaCijena;

            tbKnjigKolicina.Text = racunovodstvenaKolicina.ToString();
            tbKnjigCijena.Text = racunovodstvenaCijena.ToString("C2");
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            tbJedinicnaCijena.Text = "";

            if (tbSifra.Text != "")
            {
                if (Validacija.ProvjeriUnosBroja(tbSifra.Text))
                {
                    if (entities.Artikls.Local.Any(x => x.id == long.Parse(tbSifra.Text)))
                    {
                        tbJedinicnaCijena.Text = entities.Artikls.Local.FirstOrDefault(x => x.id == long.Parse(tbSifra.Text)).ArtiklCijenas.OrderByDescending(x => x.vrijediOd).FirstOrDefault().cijena.ToString("C2");
                    }
                    if (entities.ArtiklSkladistes.Local.Where(x => x.skaldisteId == idSkladiste).Any(x => x.artiklId == long.Parse(tbSifra.Text)))
                    {
                        lblStatus.Text = "dostupno";
                    }
                    else
                    {
                        lblStatus.Text = "nedostupno";
                    }
                }
                else
                {
                    lblStatus.Text = "neispravan unos";
                }
                
            }
            else
            {
                lblStatus.Text = "";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija.ProvjeriUnosBroja(tbSifra.Text))
            {
                MessageBox.Show("Neispravan unos šifre!");
                return;
            }

            if (!Validacija.ProvjeriUnosBroja(tbKolicina.Text))
            {
                MessageBox.Show("Neispravan unos količine!");
                return;
            }

            if (tbSifra.Text != "" && tbJedinicnaCijena.Text != "" && tbKolicina.Text != "")
            {          
                if (entities.ArtiklSkladistes.Local.Where(x => x.skaldisteId == idSkladiste).Any(x => x.artiklId == long.Parse(tbSifra.Text)))
                {
                    if (artikliInventuraList.Any(x => x.artiklId == long.Parse(tbSifra.Text)))
                    {
                        artikliInventuraList.FirstOrDefault(x => x.artiklId == long.Parse(tbSifra.Text)).kolicina += int.Parse(tbKolicina.Text);
                    }
                    else
                    {
                        artikliInventuraList.Add(new ArtiklInventura(long.Parse(tbSifra.Text), decimal.Parse(tbJedinicnaCijena.Text, System.Globalization.NumberStyles.Currency), int.Parse(tbKolicina.Text)));
                    }

                    OsvjeziDGV();
                }
                else
                {
                    MessageBox.Show("Uneseni artikl ne postoji u skladištu!");
                }
            }
        }

        private void OsvjeziDGV()
        {
            dgvPopisArtikala.DataSource = null;
            dgvPopisArtikala.DataSource = artikliInventuraList;
            dgvPopisArtikala.Columns[0].HeaderText = "Šifra artikla";
            dgvPopisArtikala.Columns[1].HeaderText = "Jedinična cijena";
            dgvPopisArtikala.Columns[2].HeaderText = "Količina";
            dgvPopisArtikala.Columns[1].Width = 150;

            tbSifra.Text = "";
            tbJedinicnaCijena.Text = "";
            tbKolicina.Text = "";
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (artikliInventuraList.Count != 0)
            {
                artikliInventuraList.Remove(dgvPopisArtikala.CurrentRow.DataBoundItem as ArtiklInventura);
            }

            OsvjeziDGV();
        }

        private void btnDohvati_Click(object sender, EventArgs e)
        {
            var ukupnaCijenaArtikla = from artikl in artikliInventuraList
                                      select artikl.kolicina * artikl.jedinicnaCijena;

            stvarnaKolicina = artikliInventuraList.Sum(x => x.kolicina);
            stvarnaCijena = ukupnaCijenaArtikla.Sum();

            tbStvKolicina.Text = stvarnaKolicina.ToString();
            tbStvCijena.Text = stvarnaCijena.ToString("C2");
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            inventurnaRazlika = stvarnaCijena - racunovodstvenaCijena;

            tbRazlika.Text = inventurnaRazlika.ToString("C2");

            if (inventurnaRazlika > 0)
            {
                tbStanje.Text = "VIŠAK";
            }
            else if (inventurnaRazlika < 0)
            {
                tbStanje.Text = "MANJAK";
            }
            else
            {
                tbStanje.Text = "IZNOSI JEDNAKI";
            }
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            entities.Inventuras.Load();

            novaInventura = new Inventura { korisnikId = idKorisnik, trgovinaId = idTrgovina, datum = dtpDatumInventure.Value, primkaKolicina = primkaKolicina, primkaCijena = primkaCijena, povratnicaKolicina = povratnicaKolicina, povratnicaCijena = povratnicaCijena, racunKolicina = racunKolicina, racunCijena = racunCijena, skladisteKolicina = stvarnaKolicina, skladisteCijena = stvarnaCijena };

            entities.Inventuras.Add(novaInventura);

            entities.SaveChanges();

            MessageBox.Show("Inventura uspješno pohranjena u bazu!");
        }

        private void btnPovijest_Click(object sender, EventArgs e)
        {
            FormPovijestInventura formPovijestInventura = new FormPovijestInventura();
            formPovijestInventura.Show();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            entities.Inventuras.Load();
            Inventura inventuraIzvjestaj = entities.Inventuras.Local.OrderByDescending(x => x.id).FirstOrDefault();

            FormInventuraIzvjestaj formInventuraIzvjestaj = new FormInventuraIzvjestaj(inventuraIzvjestaj, tbStanje.Text, inventurnaRazlika, dtpDatumInventure.Value, Autentifikator.DohvatiPrijavljenogKorisnika());
            formInventuraIzvjestaj.Show();
        }
    }
}
