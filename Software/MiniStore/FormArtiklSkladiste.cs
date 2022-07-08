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
    public partial class FormArtiklSkladiste : Form
    {
        Database entities; //= new Database();
        private VrstaOperacije vrstaOperacije;
        private Skladiste skladiste;
        private ArtiklSkladiste artiklSkladiste;

        public FormArtiklSkladiste()
        {
            InitializeComponent();
        }

        public FormArtiklSkladiste(Database entities, VrstaOperacije vrstaOperacije, Skladiste skladiste)
        {
            InitializeComponent();
            this.entities = entities;
            this.vrstaOperacije = vrstaOperacije;
            this.skladiste = skladiste;
        }

        public FormArtiklSkladiste(Database entities, VrstaOperacije vrstaOperacije, Skladiste skladiste, ArtiklSkladiste artiklSkladiste)
        {
            InitializeComponent();
            this.entities = entities ;
            this.vrstaOperacije = vrstaOperacije;
            this.skladiste = skladiste;
            this.artiklSkladiste = artiklSkladiste;
        }

        private void FormArtiklSkladiste_Load(object sender, EventArgs e)
        {
            entities.Artikls.Load();
            entities.ArtiklSkladistes.Load();
            tbSkladiste.Text = skladiste.ToString();

            if(vrstaOperacije == VrstaOperacije.Azuriranje)
            {
                tbSifra.ReadOnly = true;
                tbSifra.Text = artiklSkladiste.artiklId.ToString();
                numKolicina.Value = (decimal)artiklSkladiste.kolicina;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(vrstaOperacije == VrstaOperacije.Dodavanje)
            {
                long.TryParse(tbSifra.Text, out long unosID);

                if (entities.Artikls.Local.Any(x => x.id == unosID))
                {
                    if(!entities.ArtiklSkladistes.Local.Any(x => x.artiklId == unosID))
                    {
                        entities.ArtiklSkladistes.Add(new ArtiklSkladiste { artiklId = unosID, skaldisteId = skladiste.id, kolicina = (int)numKolicina.Value });
                        entities.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Artikl s unesenim ID-jem je već u skladištu!");
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji artikl s unesenim ID-jem.");
                }
            }

            if(vrstaOperacije == VrstaOperacije.Azuriranje)
            {
                artiklSkladiste.kolicina = (int)numKolicina.Value;
                entities.SaveChanges();
                this.Close();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
