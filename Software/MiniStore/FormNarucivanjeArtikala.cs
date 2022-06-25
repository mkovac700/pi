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
    public partial class FormNarucivanjeArtikala : Form
    {
        public int TrgovinaId { get; set; }
        List<Artikl> artikli = new List<Artikl>();
        public FormNarucivanjeArtikala()
        {
            InitializeComponent();
        }

        private void FormNarucivanjeArtikala_Load(object sender, EventArgs e)
        {

            using (var db = new Database())
            {
                cbDobavljac.DataSource = db.Dobavljacs.ToList();
                cbDobavljac.DisplayMember = "naziv";
            }
        }

        private void cbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trenutniDobavljac = cbDobavljac.SelectedItem as Dobavljac;
            using (var db = new Database())
            {
                artikli = db.Artikls.Where(p => p.dobavljacId == trenutniDobavljac.id).ToList();
            }
            dgvPopisArtikala.DataSource = artikli;

        }

        private void tbSIfraArtika_TextChanged(object sender, EventArgs e)
        {
            List<Artikl> sviArtikli = new List<Artikl>();

            using (var db = new Database())
            {
                sviArtikli = db.Artikls.ToList();
            }

            if (tbSifraArtikla.Text.Length > 0)
            {
                dgvPopisArtikala.DataSource = sviArtikli.Where(p => p.id.ToString().Contains(tbSifraArtikla.Text)).ToList();
            }
            else
            {
                dgvPopisArtikala.DataSource = artikli;
            }

        }
    }
}
