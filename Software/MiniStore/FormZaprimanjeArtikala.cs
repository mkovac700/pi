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
    public partial class FormZaprimanjeArtikala : Form
    {
        Database entities = new Database();

        private List<ArtiklPrimka> stavkePrimkeList = new List<ArtiklPrimka>();
        private List<ArtiklSkladiste> zaprimljeneStavkeList = new List<ArtiklSkladiste>();

        public FormZaprimanjeArtikala()
        {
            InitializeComponent();
        }

        private void FormZaprimanjeArtikala_Load(object sender, EventArgs e)
        {
            OsvjeziCB();
            btnSpremi.Enabled = false;

            dgvStavkePrimke.Columns[9].Visible = false;
            dgvStavkePrimke.Columns[0].HeaderText = "Šifra artikla";
            dgvStavkePrimke.Columns[1].HeaderText = "Šifra primke";
            dgvStavkePrimke.Columns[2].HeaderText = "ID dobavljača";
            dgvStavkePrimke.Columns[3].HeaderText = "ID skladišta";
            dgvStavkePrimke.Columns[4].HeaderText = "Količina";
            dgvStavkePrimke.Columns[5].HeaderText = "Cijena";
            dgvStavkePrimke.Columns[6].HeaderText = "Zaprimljeno";
            dgvStavkePrimke.Columns[7].HeaderText = "Naziv artikla";
            dgvStavkePrimke.Columns[8].HeaderText = "Naziv dobavljača";
            dgvStavkePrimke.Columns[10].HeaderText = "Oznaka trgovine";
        }

        private void btnZaprimi_Click(object sender, EventArgs e)
        {
            cbPrimke.Enabled = false;

            if(stavkePrimkeList.Count != 0)
            {
                var odabranaStavka = dgvStavkePrimke.CurrentRow.DataBoundItem as ArtiklPrimka;

                long artiklId = odabranaStavka.artiklId;
                int skladisteId = (int)odabranaStavka.skladisteId;
                int kolicina = (int)odabranaStavka.kolicina;

                zaprimljeneStavkeList.Add(new ArtiklSkladiste { artiklId = artiklId, skaldisteId = skladisteId, kolicina = kolicina });

                stavkePrimkeList.Remove(odabranaStavka);

                OsvjeziDGV();
            }

            if(zaprimljeneStavkeList.Count != 0)
            {
                btnSpremi.Enabled = true;
            }
        }

        private void OsvjeziCB()
        {
            entities.Primkas.Load();

            var primka = from primke in entities.Primkas.Local
                         where primke.skladisteId == Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault().Skladistes.FirstOrDefault().id
                         && primke.zaprimljeno == 0
                         select primke.id;

            cbPrimke.DataSource = primka.ToList();
        }

        private void OsvjeziDGV()
        {
            dgvStavkePrimke.DataSource = null;
            dgvStavkePrimke.DataSource = stavkePrimkeList;

            dgvStavkePrimke.Columns[9].Visible = false;
            dgvStavkePrimke.Columns[0].HeaderText = "Šifra artikla";
            dgvStavkePrimke.Columns[1].HeaderText = "Šifra primke";
            dgvStavkePrimke.Columns[2].HeaderText = "ID dobavljača";
            dgvStavkePrimke.Columns[3].HeaderText = "ID skladišta";
            dgvStavkePrimke.Columns[4].HeaderText = "Količina";
            dgvStavkePrimke.Columns[5].HeaderText = "Cijena";
            dgvStavkePrimke.Columns[6].HeaderText = "Zaprimljeno";
            dgvStavkePrimke.Columns[7].HeaderText = "Naziv artikla";
            dgvStavkePrimke.Columns[8].HeaderText = "Naziv dobavljača";
            dgvStavkePrimke.Columns[10].HeaderText = "Oznaka trgovine";

            dgvZaprimljeneStavke.DataSource = null;
            dgvZaprimljeneStavke.DataSource = zaprimljeneStavkeList;

            dgvZaprimljeneStavke.Columns[3].Visible = false;
            dgvZaprimljeneStavke.Columns[4].Visible = false;
            dgvZaprimljeneStavke.Columns[0].HeaderText = "Šifra artikla";
            dgvZaprimljeneStavke.Columns[1].HeaderText = "ID skladišta";
            dgvZaprimljeneStavke.Columns[2].HeaderText = "Količina";
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(zaprimljeneStavkeList.Count != 0)
            {
                entities.ArtiklSkladistes.Load();
                foreach (var zaprimljeni_artikl in zaprimljeneStavkeList)
                {
                    ArtiklSkladiste postojeci_artikl = entities.ArtiklSkladistes.FirstOrDefault(x => x.artiklId == zaprimljeni_artikl.artiklId && x.skaldisteId == zaprimljeni_artikl.skaldisteId);
                    if (postojeci_artikl != null)
                    {
                        int postojeca_kolicina = (int)postojeci_artikl.kolicina;
                        postojeci_artikl.kolicina = postojeca_kolicina + zaprimljeni_artikl.kolicina;
                        entities.SaveChanges();
                    }
                    else
                    {
                        entities.ArtiklSkladistes.Add(zaprimljeni_artikl);
                        entities.SaveChanges();
                    }

                    entities.ArtiklPrimkas.Find(zaprimljeni_artikl.artiklId, int.Parse(cbPrimke.SelectedItem.ToString())).zaprimljeno = 1;
                    entities.SaveChanges();
                }
            }

            entities.Primkas.Load();
            if(stavkePrimkeList.Count == 0)
            {
                entities.Primkas.Find(int.Parse(cbPrimke.Text)).zaprimljeno = 1;
                entities.SaveChanges();
            }

            if (chkboxPrimkaZaprimljena.Checked)
            {
                entities.Primkas.Find(int.Parse(cbPrimke.Text)).zaprimljeno = 1;
                entities.SaveChanges();
            }

            btnSpremi.Enabled = false;
            OsvjeziCB();
            stavkePrimkeList.Clear();
            zaprimljeneStavkeList.Clear();
            dgvStavkePrimke.DataSource = null;
            dgvZaprimljeneStavke.DataSource = null;
            cbPrimke.Enabled = true;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkboxPrimkaZaprimljena_CheckedChanged(object sender, EventArgs e)
        {
            btnSpremi.Enabled = true;
        }

        private void cbPrimke_SelectedValueChanged(object sender, EventArgs e)
        {
            stavkePrimkeList.Clear();
            zaprimljeneStavkeList.Clear();

            entities.ArtiklPrimkas.Load();

            var trenutnePrimke = from stavke in entities.ArtiklPrimkas.Local
                                 where stavke.primkaId == int.Parse(cbPrimke.SelectedItem.ToString()) && stavke.zaprimljeno == 0
                                 select stavke;

            stavkePrimkeList = trenutnePrimke.ToList();
            dgvStavkePrimke.DataSource = null;
            dgvStavkePrimke.DataSource = stavkePrimkeList;
        }
    }
}
