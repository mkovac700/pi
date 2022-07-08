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

namespace MiniStore
{
    public partial class FormUpravljanjeSatnicom : Form
    {
        Database entities = new Database();
        private Korisnik odabraniKorisnik;
        public FormUpravljanjeSatnicom()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private void SetMyCustomFormat()
        {
            dtpMjesec.CustomFormat = "MMMM yyyy";
            dtpMjesec.ShowUpDown = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormSatnica formSatnica = new FormSatnica(VrstaOperacije.Dodavanje, cbKorisnik.SelectedItem as Korisnik);
            var result = formSatnica.ShowDialog();
            if(result == DialogResult.OK)
            {
                OsvjeziDGV();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            FormSatnica formSatnica = new FormSatnica(VrstaOperacije.Azuriranje, cbKorisnik.SelectedItem as Korisnik, dgvSatnica.CurrentRow.DataBoundItem as Satnica);
            var result = formSatnica.ShowDialog();
            if (result == DialogResult.OK)
            {
                OsvjeziDGV();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            entities.Satnicas.Remove(entities.Satnicas.Find((dgvSatnica.CurrentRow.DataBoundItem as Satnica).id));
            entities.SaveChanges();
            OsvjeziDGV();
        }

        private void FormUpravljanjeSatnicom_Load(object sender, EventArgs e)
        {
            entities.Korisniks.Load();
            entities.Trgovinas.Load();

            PostaviGumbove();
            PostaviFilter();

            rbSve.Checked = true;

            OsvjeziDGV();
        }

        private void OsvjeziDGV()
        {
            entities.Satnicas.Load();

            //dodano zbog azuriranja (zbog cinjenice da se promjena vrsi u kontekstu druge forme, potrebno je prisilno reloadati zapise u kontekstu ove forme
            foreach(var item in entities.Satnicas.Local)
            {
                entities.Entry(item).Reload();
            }

            if (rbSve.Checked)
            {
                dgvSatnica.DataSource = null;
                dgvSatnica.DataSource = (from satnica in entities.Satnicas.Local
                                        where satnica.Korisnik.id == (cbKorisnik.SelectedItem as Korisnik).id
                                        select satnica).ToList();

                dgvSatnica.Columns[0].Visible = false;
                dgvSatnica.Columns[1].Visible = false;
                dgvSatnica.Columns[2].HeaderText = "Datum";
                dgvSatnica.Columns[3].HeaderText = "Broj sati";
                dgvSatnica.Columns[3].DisplayIndex = 1;
                dgvSatnica.Columns[4].DisplayIndex = 0;
            }
            if (rbMjeseci.Checked)
            {
                dgvSatnica.DataSource = null;
                dgvSatnica.DataSource = (from satnica in entities.Satnicas.Local
                                        where satnica.Korisnik.id == (cbKorisnik.SelectedItem as Korisnik).id && satnica.datum.Value.Month == dtpMjesec.Value.Month && satnica.datum.Value.Year == dtpMjesec.Value.Year
                                        select satnica).ToList();

                dgvSatnica.Columns[0].Visible = false;
                dgvSatnica.Columns[1].Visible = false;
                dgvSatnica.Columns[2].HeaderText = "Datum";
                dgvSatnica.Columns[3].HeaderText = "Broj sati";
                dgvSatnica.Columns[3].DisplayIndex = 1;
                dgvSatnica.Columns[4].DisplayIndex = 0;
            }
        }

        private void PostaviGumbove()
        {
            foreach(var item in this.Controls)
            {
                if(item.GetType() == typeof(Button))
                {
                    (item as Button).Enabled = false;
                }
            }

            if(Autentifikator.DohvatiRazinuPrijavljenogKorisnika() <= 3) //zaposlenik moze samo dodavati zapis i ispisati izvjesce
            {
                btnDodaj.Enabled = true;
                btnIspis.Enabled = true;
            }

            if(Autentifikator.DohvatiRazinuPrijavljenogKorisnika() <= 2) //admin trgovine kao i superuser moze sve ostalo
            {
                btnUredi.Enabled = true;
                btnObrisi.Enabled = true;
            } 
        }

        private void PostaviFilter()
        {
            switch (Autentifikator.DohvatiRazinuPrijavljenogKorisnika())
            {
                case 3: //zaposlenik moze odabrati samo svoju poslovnicu i samo sebe
                    cbPoslovnica.Items.Add(Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault());
                    cbPoslovnica.SelectedItem = cbPoslovnica.Items[0];
                    cbKorisnik.Items.Add(Autentifikator.DohvatiPrijavljenogKorisnika());
                    cbKorisnik.SelectedItem = cbKorisnik.Items[0];
                    break;
                case 2: //voditelj moze odabrati samo svoju poslovnicu i sve zaposlenike iz te poslovnice
                    cbPoslovnica.Items.Add(Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault());
                    cbPoslovnica.SelectedItem = cbPoslovnica.Items[0];
                    cbKorisnik.DataSource = (cbPoslovnica.Items[0] as Trgovina).Korisniks.ToList();
                    break;
                case 1: //superadmin moze odabrati sve poslovnice i sve zaposlenike u odabranoj poslovnici
                    cbPoslovnica.DataSource = entities.Trgovinas.Local.ToList();
                    cbPoslovnica.SelectedItem = cbPoslovnica.Items[0];
                    cbKorisnik.DataSource = (cbPoslovnica.Items[0] as Trgovina).Korisniks.ToList();
                    break;
                default:
                    MessageBox.Show("Greška kod dohvaćanja prijavljenog korisnika!");
                    break;
            }
        }

        private void cbPoslovnica_SelectedIndexChanged(object sender, EventArgs e)
        {
            //s obzirom da samo superuser moze mijenjati poslovnice, sprjecava se izvrsavanje eventa za druge korisnike
            if (Autentifikator.DohvatiRazinuPrijavljenogKorisnika() == 1) OsvjeziCBKorisnik(); 
        }

        private void OsvjeziCBKorisnik()
        {
            cbKorisnik.DataSource = null;
            cbKorisnik.DataSource = (cbPoslovnica.SelectedItem as Trgovina).Korisniks.ToList();
        }

        private void cbKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziDGV();
            odabraniKorisnik = cbKorisnik.SelectedItem as Korisnik;
        }

        private void rbSve_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziDGV();
        }

        private void rbMjeseci_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziDGV();
        }

        private void dtpMjesec_ValueChanged(object sender, EventArgs e)
        {
            OsvjeziDGV();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            entities.Satnicas.Load();

            foreach (var item in entities.Satnicas.Local)
            {
                entities.Entry(item).Reload();
            }

            if (rbSve.Checked)
            {
                var satnice = (from satnica in entities.Satnicas.Local
                               where satnica.Korisnik.id == odabraniKorisnik.id
                               select satnica);

                FormUpravljanjeSatnicomIzvjestaj formUpravljanjeSatnicomIzvjestaj = new FormUpravljanjeSatnicomIzvjestaj(satnice, cbKorisnik.SelectedItem as Korisnik);
                formUpravljanjeSatnicomIzvjestaj.Show();
            }
            if (rbMjeseci.Checked)
            {
                var satnice = (from satnica in entities.Satnicas.Local
                               where satnica.Korisnik.id == odabraniKorisnik.id && satnica.datum.Value.Month == dtpMjesec.Value.Month && satnica.datum.Value.Year == dtpMjesec.Value.Year
                               select satnica);

                FormUpravljanjeSatnicomIzvjestaj formUpravljanjeSatnicomIzvjestaj = new FormUpravljanjeSatnicomIzvjestaj(satnice, cbKorisnik.SelectedItem as Korisnik, dtpMjesec.Value);
                formUpravljanjeSatnicomIzvjestaj.Show();
            }
        }
    }
}
