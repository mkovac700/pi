using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace MiniStore
{
    public partial class FormUpravljanjeArtiklima : Form
    {
        Database entities = new Database();
        private Korisnik prijavljeniKorisnik;
        public FormUpravljanjeArtiklima()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (rbSvi.Checked)
            {
                FormArtikl formArtikl = new FormArtikl(entities, VrstaOperacije.Dodavanje);
                var result = formArtikl.ShowDialog();
                if (result == DialogResult.OK) OsvjeziDGVSviArtikli();
            }
            
            if (rbSkladiste.Checked)
            {
                FormArtiklSkladiste formArtiklSkladiste = new FormArtiklSkladiste(entities, VrstaOperacije.Dodavanje, cbSkladiste.SelectedItem as Skladiste);
                formArtiklSkladiste.ShowDialog();
                OsvjeziDGVArtikliSkladiste();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (rbSvi.Checked)
            {
                FormArtikl formArtikl = new FormArtikl(entities, VrstaOperacije.Azuriranje, dgvArtikli.CurrentRow.DataBoundItem as Artikl);
                var result = formArtikl.ShowDialog();
                if (result == DialogResult.OK) OsvjeziDGVSviArtikli();
            }

            if (rbSkladiste.Checked)
            {
                FormArtiklSkladiste formArtiklSkladiste = new FormArtiklSkladiste(entities, VrstaOperacije.Azuriranje, cbSkladiste.SelectedItem as Skladiste, dgvArtikli.CurrentRow.DataBoundItem as ArtiklSkladiste);
                formArtiklSkladiste.ShowDialog();
                OsvjeziDGVArtikliSkladiste();
            }
        }

        private void FormUpravljanjeArtiklima_Load(object sender, EventArgs e)
        {
            prijavljeniKorisnik = Autentifikator.DohvatiPrijavljenogKorisnika();
            entities.Skladistes.Load();

            switch (Autentifikator.DohvatiRazinuPrijavljenogKorisnika())
            {
                case 2:
                    rbSvi.Enabled = false;
                    rbSkladiste.Checked = true;
                    cbSkladiste.DataSource = prijavljeniKorisnik.Trgovinas.FirstOrDefault().Skladistes.ToList();
                    OsvjeziDGVArtikliSkladiste();
                    break;
                case 1:
                    rbSvi.Checked = true;
                    cbSkladiste.DataSource = entities.Skladistes.Local.ToList();
                    OsvjeziDGVSviArtikli();
                    break;
                default:
                    break;
            }
        }

        private void OsvjeziDGVSviArtikli()
        {
            entities.ArtiklCijenas.Load();
            entities.Artikls.Load();
            dgvArtikli.DataSource = null;
            dgvArtikli.DataSource = entities.Artikls.Local.ToList();

            dgvArtikli.Columns[0].HeaderText = "Relevantna cijena (kn)";
            dgvArtikli.Columns[0].Width = 150;
            dgvArtikli.Columns[0].DefaultCellStyle.Format = "#.##";

            dgvArtikli.Columns[1].HeaderText = "Šifra";

            dgvArtikli.Columns[2].HeaderText = "Naziv";
            dgvArtikli.Columns[2].Width = 200;

            dgvArtikli.Columns[3].HeaderText = "Kategorija";

            dgvArtikli.Columns[4].Visible = false;

            dgvArtikli.Columns[5].HeaderText = "Dobavljač";
            dgvArtikli.Columns[5].Width = 200;

            dgvArtikli.Columns[0].DisplayIndex = 5;
            dgvArtikli.Columns[1].DisplayIndex = 0;
            dgvArtikli.Columns[2].DisplayIndex = 1;
            dgvArtikli.Columns[4].DisplayIndex = 3;
            dgvArtikli.Columns[3].DisplayIndex = 2;
            dgvArtikli.Columns[5].DisplayIndex = 4;

            for (int i = 6; i < dgvArtikli.Columns.Count; i++)
            {
                dgvArtikli.Columns[i].Visible = false;
            }
        }

        private void OsvjeziDGVArtikliSkladiste()
        {
            //entities.ArtiklCijenas.Load();
            entities.ArtiklSkladistes.Load();
            dgvArtikli.DataSource = null;
            dgvArtikli.DataSource = entities.ArtiklSkladistes.Local.Where(x => x.skaldisteId == (cbSkladiste.SelectedItem as Skladiste).id).ToList();

            dgvArtikli.Columns[0].HeaderText = "Šifra";
            dgvArtikli.Columns[1].Visible = false;
            dgvArtikli.Columns[2].HeaderText = "Količina";
            dgvArtikli.Columns[3].HeaderText = "Naziv";
            dgvArtikli.Columns[3].Width = 200;
            dgvArtikli.Columns[4].HeaderText = "Skladište";

            dgvArtikli.Columns[3].DisplayIndex = 1;
        }

        private void rbSvi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSvi.Checked)
            {
                OsvjeziDGVSviArtikli();
            }
        }

        private void rbSkladiste_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSkladiste.Checked && cbSkladiste.SelectedItem != null)
            {
                OsvjeziDGVArtikliSkladiste();
            }
        }

        private void cbSkladiste_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rbSkladiste.Checked)
            {
                OsvjeziDGVArtikliSkladiste();
            }
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            string odabraniID = "0";
            if (rbSvi.Checked)
            {
                odabraniID = (dgvArtikli.CurrentRow.DataBoundItem as Artikl).id.ToString().PadLeft(12, '0');
            }
            if (rbSkladiste.Checked)
            {
                odabraniID = (dgvArtikli.CurrentRow.DataBoundItem as ArtiklSkladiste).artiklId.ToString().PadLeft(12, '0');
            }

            Barcode barcode = new Barcode();
            Image barcodeImg = barcode.Encode(TYPE.UPCA, odabraniID, Color.Black, Color.White, 100, 30);

            this.barcodeData.Clear();

            using (MemoryStream ms = new MemoryStream())
            {
                barcodeImg.Save(ms, ImageFormat.Png);

                for (int i = 0; i < 16; i++) 
                {
                    this.barcodeData.Barcode.AddBarcodeRow(odabraniID, ms.ToArray());
                }
            }

            FormUpravljanjeArtiklimaIzvjestaj formUpravljanjeArtiklimaIzvjestaj = new FormUpravljanjeArtiklimaIzvjestaj(barcodeData.Barcode);
            formUpravljanjeArtiklimaIzvjestaj.Show();
        }
    }
}
