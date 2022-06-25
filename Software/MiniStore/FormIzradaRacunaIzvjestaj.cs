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
    public partial class FormIzradaRacunaIzvjestaj : Form
    {
        public RacunIzvjestaj Podaci { get; set; }
        public FormIzradaRacunaIzvjestaj()
        {
            InitializeComponent();
        }

        private void FormIzradaRacunaIzvjestaj_Load(object sender, EventArgs e)
        {
            var glavniDS = new ReportDataSource("RacunIzvjestaj", new List<RacunIzvjestaj> { Podaci });
            var sporedniDS = new ReportDataSource("RacunIzvjestajStavka", Podaci.Stavke);
            rvRacun.LocalReport.DataSources.Clear();
            rvRacun.LocalReport.DataSources.Add(glavniDS);
            rvRacun.LocalReport.DataSources.Add(sporedniDS);

            this.rvRacun.RefreshReport();
        }
    }
}
