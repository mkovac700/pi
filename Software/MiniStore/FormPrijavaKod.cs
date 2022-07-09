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
    public partial class FormPrijavaKod : Form
    {
        public string kod;
        public FormPrijavaKod()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if(tbKod.Text != "")
            {
                kod = tbKod.Text;
            }
            else
            {
                MessageBox.Show("Niste unijeli kod!");
            }
        }
    }
}
