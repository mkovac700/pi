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
    public partial class FormNarucivanjeArtikalaIzvjestaj : Form
    {
        public NarudzbenicaIzvjestaj Podaci { get; set; }
        public FormNarucivanjeArtikalaIzvjestaj()
        {
            InitializeComponent();
        }


        private void FormNarucivanjeArtikalaIzvjestaj_Load(object sender, EventArgs e)
        {

            var glavniDS = new ReportDataSource("NarudzbenicaIzvjestaj", new List<NarudzbenicaIzvjestaj> { Podaci });
            var sporedniDS = new ReportDataSource("NarudzbenicaIzvjestajStavka", Podaci.Artikli);
            rvNarudzbenica.LocalReport.DataSources.Clear();
            rvNarudzbenica.LocalReport.DataSources.Add(glavniDS);
            rvNarudzbenica.LocalReport.DataSources.Add(sporedniDS);

            this.rvNarudzbenica.RefreshReport();
        }
    }
}
