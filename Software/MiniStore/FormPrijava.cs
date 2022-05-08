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
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlavnaForma glavnaForma = new GlavnaForma();
            glavnaForma.ShowDialog();
        }
    }
}
