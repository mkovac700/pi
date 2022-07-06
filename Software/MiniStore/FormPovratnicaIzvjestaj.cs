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
    public partial class FormPovratnicaIzvjestaj : Form
    {
        private Povratnica novaPovratnica;
        private IEnumerable<ArtiklPovratnica> noviArtikliPovratnice;
        private Dobavljac dobavljac;
        private Korisnik korisnik;

        public FormPovratnicaIzvjestaj()
        {
            InitializeComponent();
        }

        public FormPovratnicaIzvjestaj(Povratnica novaPovratnica, IEnumerable<ArtiklPovratnica> noviArtikliPovratnice, Dobavljac dobavljac)
        {
            InitializeComponent();
            this.novaPovratnica = novaPovratnica;
            this.noviArtikliPovratnice = noviArtikliPovratnice;
            this.dobavljac = dobavljac;
            this.korisnik = Autentifikator.DohvatiPrijavljenogKorisnika();
        }

        private void FormPovratnicaIzvjestaj_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("ArtiklPovratnicaDataset", noviArtikliPovratnice);

            this.reportViewerPovratnica.LocalReport.DataSources.Clear();
            this.reportViewerPovratnica.LocalReport.DataSources.Add(rds);

            this.reportViewerPovratnica.LocalReport.SetParameters(new ReportParameter("paramID", novaPovratnica.id.ToString()));
            this.reportViewerPovratnica.LocalReport.SetParameters(new ReportParameter("paramDatumVrijeme", novaPovratnica.datumVrijeme.ToString()));
            this.reportViewerPovratnica.LocalReport.SetParameters(new ReportParameter("paramZaposlenik", korisnik.ToString()));
            this.reportViewerPovratnica.LocalReport.SetParameters(new ReportParameter("paramTrgovina", korisnik.Trgovinas.FirstOrDefault().ToString()));
            this.reportViewerPovratnica.LocalReport.SetParameters(new ReportParameter("paramDobavljac", dobavljac.ToString()));

            this.reportViewerPovratnica.RefreshReport();
        }
    }
}
