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
    public partial class FormPostavke : Form
    {
        private Korisnik prijavljeniKorisnik;
        public FormPostavke()
        {
            InitializeComponent();
        }

        private void FormPostavke_Load(object sender, EventArgs e)
        {
            prijavljeniKorisnik = Autentifikator.DohvatiPrijavljenogKorisnika();

            foreach(var item in tlpGumbovi.Controls){
                (item as Button).Enabled = false;
            }

            if(Autentifikator.DohvatiRazinuPrijavljenogKorisnika() <= 3)
            {
                btnAbout.Enabled = true;
            }
            if(Autentifikator.DohvatiRazinuPrijavljenogKorisnika() <= 2)
            {
                btnPostavkeSucelja.Enabled = true;
            }
            if(Autentifikator.DohvatiRazinuPrijavljenogKorisnika() == 1)
            {
                btnRegistracija.Enabled = true;
            }

            pnlGlavni.Controls.Clear();
            FormAbout formAbout = new FormAbout
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                Dock = DockStyle.Fill
            };
            pnlGlavni.Controls.Add(formAbout);
            formAbout.Show();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            FormRegistracija formRegistracija = new FormRegistracija
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                Dock = DockStyle.Fill
            };
            pnlGlavni.Controls.Add(formRegistracija);
            formRegistracija.Show();
        }

        private void btnPostavkeSucelja_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            FormPostavkeSucelja formPostavkeSucelja = new FormPostavkeSucelja
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                Dock = DockStyle.Fill
            };
            pnlGlavni.Controls.Add(formPostavkeSucelja);
            formPostavkeSucelja.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            FormAbout formAbout = new FormAbout
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                Dock = DockStyle.Fill
            };
            pnlGlavni.Controls.Add(formAbout);
            formAbout.Show();
        }
    }
}
