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
    public partial class FormUpravljanjeSatnicom : Form
    {
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
            PostaviGumbove();
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
    }
}
