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
            entities.Primkas.Load();

            var primka = from primke in entities.Primkas.Local
                         select primke.id;

            cbPrimke.DataSource = primka.ToList();

            btnSpremi.Enabled = false;
        }

        private void cbPrimke_SelectedIndexChanged(object sender, EventArgs e)
        {
            entities.ArtiklPrimkas.Load();

            var trenutnePrimke = from stavke in entities.ArtiklPrimkas.Local
                                 where stavke.primkaId == int.Parse(cbPrimke.Text)
                                 select stavke;

            stavkePrimkeList = trenutnePrimke.ToList();
            dgvStavkePrimke.DataSource = null;
            dgvStavkePrimke.DataSource = stavkePrimkeList;
        }

        private void btnZaprimi_Click(object sender, EventArgs e)
        {
            if(stavkePrimkeList.Count != 0)
            {
                var odabranaStavka = dgvStavkePrimke.CurrentRow.DataBoundItem as ArtiklPrimka;

                int artiklId = odabranaStavka.artiklId;
                int skladisteId = (int)odabranaStavka.skladisteId;
                int kolicina = (int)odabranaStavka.kolicina;

                zaprimljeneStavkeList.Add(new ArtiklSkladiste { artiklId = artiklId, skaldisteId = skladisteId, kolicina = kolicina });

                stavkePrimkeList.Remove(odabranaStavka);

                OsvjeziListe();
            }

            if(zaprimljeneStavkeList.Count != 0)
            {
                btnSpremi.Enabled = true;
            }
        }

        private void OsvjeziListe()
        {
            dgvStavkePrimke.DataSource = null;
            dgvStavkePrimke.DataSource = stavkePrimkeList;

            dgvZaprimljeneStavke.DataSource = null;
            dgvZaprimljeneStavke.DataSource = zaprimljeneStavkeList;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
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
                
            }

            btnSpremi.Enabled = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
