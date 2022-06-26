using Microsoft.Reporting.WinForms;
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
    public partial class FormStatistikaProdajeUkupnoPoslovanjeIzvjestaj : Form
    {
        public StatistikaProdajeUkupnoPoslovanje Podaci { get; set; }
        public FormStatistikaProdajeUkupnoPoslovanjeIzvjestaj()
        {
            InitializeComponent();
        }

        private void FormStatistikaProdajeSviArtikliIzvjestaj_Load(object sender, EventArgs e)
        {
          
            var sporedniDS = new ReportDataSource("StatistikaProdajeUkupnoArtikli", Podaci.ProdajaArtikala);
            var sporedniDS2 = new ReportDataSource("StatistikaProdajeUkupnoKategorije", Podaci.ProdajaKategorija);
            rvIzvjestaj.LocalReport.DataSources.Clear();
            rvIzvjestaj.LocalReport.DataSources.Add(sporedniDS);
            rvIzvjestaj.LocalReport.DataSources.Add(sporedniDS2);

            
            this.rvIzvjestaj.RefreshReport();
        }
    }
}
