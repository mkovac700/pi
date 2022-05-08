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
    public partial class FormUpravljanjeArtiklima : Form
    {
        public FormUpravljanjeArtiklima()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormArtikl formArtikl = new FormArtikl();
            formArtikl.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            FormArtikl formArtikl = new FormArtikl();
            formArtikl.ShowDialog();
        }
    }
}
