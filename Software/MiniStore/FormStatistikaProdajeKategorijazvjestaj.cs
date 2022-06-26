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
    public partial class FormStatistikaProdajeKategorijazvjestaj : Form
    {
        public FormStatistikaProdajeKategorijazvjestaj()
        {
            InitializeComponent();
        }

        private void FormStatistikaProdajeKategorijazvjestaj_Load(object sender, EventArgs e)
        {

            this.rvIzvjestaj.RefreshReport();
        }
    }
}
