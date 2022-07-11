using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class FormPovijestInventura : Form
    {
        Database entities = new Database();

        private int idTrgovina;

        public FormPovijestInventura()
        {
            InitializeComponent();
        }

        private void FormPovijestInventura_Load(object sender, EventArgs e)
        {
            idTrgovina = Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault().id;

            entities.Inventuras.Load();

            var inventure = from inventura in entities.Inventuras.Local
                            where inventura.trgovinaId == idTrgovina
                            select inventura;

            dgvPovijestInventura.DataSource = inventure.ToList();

            dgvPovijestInventura.Columns[12].Visible = false;
            dgvPovijestInventura.Columns[13].Visible = false;
            dgvPovijestInventura.Columns[0].HeaderText = "Šifra inventure";
            dgvPovijestInventura.Columns[1].HeaderText = "Korisnik";
            dgvPovijestInventura.Columns[2].HeaderText = "Trgovina";
            dgvPovijestInventura.Columns[3].HeaderText = "Datum inventure";
            dgvPovijestInventura.Columns[4].HeaderText = "Ukupna količina - primke";
            dgvPovijestInventura.Columns[5].HeaderText = "Ukupna cijena - primke";
            dgvPovijestInventura.Columns[6].HeaderText = "Ukupna količina - povratnice";
            dgvPovijestInventura.Columns[7].HeaderText = "Ukupna cijena - povratnice";
            dgvPovijestInventura.Columns[8].HeaderText = "Ukupna količina - računi";
            dgvPovijestInventura.Columns[9].HeaderText = "Ukupna cijena - računi";
            dgvPovijestInventura.Columns[10].HeaderText = "Ukupna količina - stvarna";
            dgvPovijestInventura.Columns[11].HeaderText = "Ukupna cijena - stvarna";
            dgvPovijestInventura.Columns[5].DefaultCellStyle.Format = "C2";
            dgvPovijestInventura.Columns[7].DefaultCellStyle.Format = "C2";
            dgvPovijestInventura.Columns[9].DefaultCellStyle.Format = "C2";
            dgvPovijestInventura.Columns[11].DefaultCellStyle.Format = "C2";
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
