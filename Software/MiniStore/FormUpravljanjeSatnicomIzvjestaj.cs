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
    public partial class FormUpravljanjeSatnicomIzvjestaj : Form
    {
        private IEnumerable<Satnica> satnice;
        private Korisnik korisnik;
        private DateTime datum;

        public FormUpravljanjeSatnicomIzvjestaj()
        {
            InitializeComponent();
        }

        public FormUpravljanjeSatnicomIzvjestaj(IEnumerable<Satnica> satnice, Korisnik korisnik)
        {
            InitializeComponent();
            this.satnice = satnice;
            this.korisnik = korisnik;
        }

        public FormUpravljanjeSatnicomIzvjestaj(IEnumerable<Satnica> satnice, Korisnik korisnik, DateTime datum)
        {
            InitializeComponent();
            this.satnice = satnice;
            this.korisnik = korisnik;
            this.datum = datum; 
        }

        private void FormUpravljanjeSatnicomIzvjestaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource("SatnicaDataset", satnice);
            this.reportViewerSatnica.LocalReport.DataSources.Clear();
            this.reportViewerSatnica.LocalReport.DataSources.Add(rds);

            this.reportViewerSatnica.LocalReport.SetParameters(new ReportParameter("paramImePrezime", korisnik.ime+" "+korisnik.prezime));
            this.reportViewerSatnica.LocalReport.SetParameters(new ReportParameter("paramTrgovina", korisnik.Trgovinas.FirstOrDefault().ToString()));
            this.reportViewerSatnica.LocalReport.SetParameters(new ReportParameter("paramSifra", korisnik.id.ToString()));

            if(datum != DateTime.MinValue)//ako je datum postavljen, tj. nema min value (1)
            {
                this.reportViewerSatnica.LocalReport.SetParameters(new ReportParameter("paramMjesec", datum.Month.ToString()));
                this.reportViewerSatnica.LocalReport.SetParameters(new ReportParameter("paramGodina", datum.Year.ToString()));
            }

            this.reportViewerSatnica.RefreshReport();
        }
    }
}
