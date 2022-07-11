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
    public partial class FormUpravljanjeArtiklimaIzvjestaj : Form
    {
        private BarcodeData.BarcodeDataTable barcode;

        public FormUpravljanjeArtiklimaIzvjestaj()
        {
            InitializeComponent();
        }

        public FormUpravljanjeArtiklimaIzvjestaj(BarcodeData.BarcodeDataTable barcode)
        {
            InitializeComponent();
            this.barcode = barcode;
        }

        private void FormUpravljanjeArtiklimaIzvjestaj_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "BarcodeDataset";
            rds.Value = barcode;

            reportViewerBarcodeIzvjestaj.LocalReport.EnableExternalImages = true;
            reportViewerBarcodeIzvjestaj.LocalReport.DataSources.Clear();
            reportViewerBarcodeIzvjestaj.LocalReport.DataSources.Add(rds);

            this.reportViewerBarcodeIzvjestaj.RefreshReport();
        }
    }
}
