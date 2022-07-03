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
            FormSatnica formSatnica = new FormSatnica();
            formSatnica.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            FormSatnica formSatnica = new FormSatnica();
            formSatnica.ShowDialog();
        }

        private void FormUpravljanjeSatnicom_Load(object sender, EventArgs e)
        {
            entities.Korisniks.Load();
            entities.Trgovinas.Load();

            PostaviGumbove();
            PostaviFilter();
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
    }
}
