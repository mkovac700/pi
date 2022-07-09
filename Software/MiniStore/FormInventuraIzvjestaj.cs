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
    public partial class FormInventuraIzvjestaj : Form
    {
        private Inventura inventuraIzvjestaj;
        private string stanje;
        private decimal inventurnaRazlika;
        private DateTime datum;
        private Korisnik korisnik;

        public FormInventuraIzvjestaj()
        {
            InitializeComponent();
        }

        public FormInventuraIzvjestaj(Inventura inventuraIzvjestaj, string stanje, decimal inventurnaRazlika, DateTime datum, Korisnik korisnik)
        {
            InitializeComponent();
            this.inventuraIzvjestaj = inventuraIzvjestaj;
            this.stanje = stanje;
            this.inventurnaRazlika = inventurnaRazlika;
            this.datum = datum;
            this.korisnik = korisnik;
        }

        private void FormInventuraIzvjestaj_Load(object sender, EventArgs e)
        {
            List<Inventura> inventuraList = new List<Inventura>();
            inventuraList.Add(inventuraIzvjestaj);
            ReportDataSource rds = new ReportDataSource("InventuraDataset",inventuraList);

            this.reportViewerInventura.LocalReport.DataSources.Clear();
            this.reportViewerInventura.LocalReport.DataSources.Add(rds);

            this.reportViewerInventura.LocalReport.SetParameters(new ReportParameter("paramKorisnik", korisnik.ToString()));
            this.reportViewerInventura.LocalReport.SetParameters(new ReportParameter("paramID", inventuraIzvjestaj.id.ToString()));
            this.reportViewerInventura.LocalReport.SetParameters(new ReportParameter("paramTrgovina", korisnik.Trgovinas.FirstOrDefault().ToString()));
            this.reportViewerInventura.LocalReport.SetParameters(new ReportParameter("paramDatum", datum.ToString()));
            this.reportViewerInventura.LocalReport.SetParameters(new ReportParameter("paramRazlika", inventurnaRazlika.ToString("C2")));
            this.reportViewerInventura.LocalReport.SetParameters(new ReportParameter("paramStanje", stanje));

            this.reportViewerInventura.RefreshReport();
        }
    }
}
