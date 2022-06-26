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
    public partial class FormStatistikaProdajeArtiklIzvjestaj : Form
    {
        public StatistikaProdajeArtikl Podaci { get; set; }
        public FormStatistikaProdajeArtiklIzvjestaj()
        {
            InitializeComponent();
        }

        private void FormStatistikaProdajeIzvjestaj_Load(object sender, EventArgs e)
        {
            var glavniDS = new ReportDataSource("StatistikaProdajeArtikl", new List<StatistikaProdajeArtikl> { Podaci });
            var sporedniDS = new ReportDataSource("StatistikaProdajeArtiklStavkaVrijeme", Podaci.ProdajaPoKvartaluVrijeme);
            var sporedniDS2 = new ReportDataSource("StatistikaProdajeArtiklStavkaTrgovina", Podaci.ProdajaPoKvartaluTrgovina);
            rvIzvjesce.LocalReport.DataSources.Clear();
            rvIzvjesce.LocalReport.DataSources.Add(glavniDS);
            rvIzvjesce.LocalReport.DataSources.Add(sporedniDS);
            rvIzvjesce.LocalReport.DataSources.Add(sporedniDS2);
            this.rvIzvjesce.RefreshReport();
        }
    }
}
