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
using GeneratorLib;

namespace MiniStore
{
    public partial class FormRegistracija : Form
    {
        Database entities = new Database();
        public FormRegistracija()
        {
            InitializeComponent();
        }

        private void FormRegistracija_Load(object sender, EventArgs e)
        {
            entities.Korisniks.Load();
            entities.VrstaKorisnikas.Load();
            cbVrstaKorisnika.DataSource = entities.VrstaKorisnikas.Local.Where(x => x.id != 1).ToList();
        }

        private void btnGenerirajSifru_Click(object sender, EventArgs e)
        {
            tbLozinka.Text = Generator.GenerirajSifru(8);
        }

        private void btnGenerirajKod_Click(object sender, EventArgs e)
        {
            tbKod.Text = Generator.GenerirajSifru(16);
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            if (tbIme.Text == "" || tbPrezime.Text == "" || tbAdresa.Text == "" || tbKorisnickoIme.Text == "" || tbLozinka.Text == "" || tbKod.Text == "")
            {
                MessageBox.Show("Nisu ispunjena sva polja!");
            }
            else if(entities.Korisniks.Local.Any(x => x.korisnickoIme == tbKorisnickoIme.Text))
            {
                MessageBox.Show("Korisnik s unesenim korisničkim imenom je već registriran!");
            }
            else
            {
                entities.Korisniks.Add(new Korisnik { ime = tbIme.Text, prezime = tbPrezime.Text, adresa = tbAdresa.Text, datumRodjenja = dtpDatumRodenja.Value.Date, korisnickoIme = tbKorisnickoIme.Text, lozinka = tbLozinka.Text, vrstaKorisnika = (cbVrstaKorisnika.SelectedItem as VrstaKorisnika).id, registriran = 0, kod = tbKod.Text });
                entities.SaveChanges();
                MessageBox.Show("Registracija uspješna!");
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbKorisnickoIme.Text = "";
            tbLozinka.Text = "";
            tbKod.Text = "";
            tbAdresa.Text = "";
            dtpDatumRodenja.ResetText();
        }
    }
}
