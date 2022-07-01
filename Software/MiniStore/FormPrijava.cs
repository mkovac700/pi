﻿using System;
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
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();
        }

        private void FormPrijava_Load(object sender, EventArgs e)
        {
            //random test
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            IzvrsiPrijavu();
        }

        private void IzvrsiPrijavu()
        {
            if (tbKorisnickoIme.Text != "" && tbLozinka.Text != "")
            {
                Autentifikator.PrijaviKorisnika(tbKorisnickoIme.Text, tbLozinka.Text);

                tbKorisnickoIme.Text = "";
                tbLozinka.Text = "";

                if (Autentifikator.DohvatiPrijavljenogKorisnika() != null)
                {
                    this.Hide();

                    GlavnaForma glavnaForma = new GlavnaForma();
                    glavnaForma.ShowDialog();

                    this.Show();
                }
                else
                {
                    MessageBox.Show("Netocni podatci. Molimo pokusajte ponovno!");
                }
            }
            else
            {
                MessageBox.Show("Netocni podatci. Molimo pokusajte ponovno!");
            }
        }

        private void tbLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                IzvrsiPrijavu();
            } 
        }

        private void tbKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                IzvrsiPrijavu();
            }
        }
    }
}
