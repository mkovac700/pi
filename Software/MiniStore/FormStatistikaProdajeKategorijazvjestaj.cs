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
    public partial class FormStatistikaProdajeKategorijazvjestaj : Form
    {
        public StatistikaProdajeKategorija Podaci { get; set; }
        public FormStatistikaProdajeKategorijazvjestaj()
        {
            InitializeComponent();
        }

        private void FormStatistikaProdajeKategorijazvjestaj_Load(object sender, EventArgs e)
        {
            var glavniDS = new ReportDataSource("StatistikaProdajeKategorija", new List<StatistikaProdajeKategorija> { Podaci });
            var sporedniDS = new ReportDataSource("StatistikaProdajeKategorijaStavkaVrijeme", Podaci.ProdajaPoKvartaluVrijeme);
            var sporedniDS2 = new ReportDataSource("StatistikaProdajeKategorijaStavkaTrgovina", Podaci.ProdajaPoKvartaluTrgovina);
            rvIzvjestaj.LocalReport.DataSources.Clear();
            rvIzvjestaj.LocalReport.DataSources.Add(glavniDS);
            rvIzvjestaj.LocalReport.DataSources.Add(sporedniDS);
            rvIzvjestaj.LocalReport.DataSources.Add(sporedniDS2);

            this.rvIzvjestaj.RefreshReport();
      
        }
    }
}
