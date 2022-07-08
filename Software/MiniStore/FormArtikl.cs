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
using GeneratorLib;

namespace MiniStore
{
    public partial class FormArtikl : Form
    {
        Database entities;
        private Artikl artikl;
        private ArtiklCijena artiklCijena;
        private VrstaOperacije vrstaOperacije;

        public FormArtikl()
        {
            InitializeComponent();
        }

        public FormArtikl(Database entities, VrstaOperacije vrstaOperacije)
        {
            InitializeComponent();
            this.entities = entities;
            this.vrstaOperacije = vrstaOperacije;
        }

        public FormArtikl(Database entities, VrstaOperacije vrstaOperacije, Artikl postojeciArtikl)
        {
            InitializeComponent();
            this.entities = entities ;
            this.vrstaOperacije = vrstaOperacije;
            this.artikl = postojeciArtikl;
        }

        private void FormArtikl_Load(object sender, EventArgs e)
        {
            entities.Dobavljacs.Load();
            entities.Artikls.Load();
            entities.ArtiklCijenas.Load();
            cbDobavljac.DataSource = entities.Dobavljacs.Local.ToList();
            cbKategorija.DataSource = entities.Artikls.Local.Select(x => x.kategorija).Distinct().ToList();

            if (vrstaOperacije == VrstaOperacije.Dodavanje)
            {
                tbSifra.Text = Generator.GenerirajBarkod().ToString();
            }

            if (vrstaOperacije == VrstaOperacije.Azuriranje)
            {
                btnGenerirajSifru.Enabled = false;
                tbSifra.Text = artikl.id.ToString();
                tbNaziv.Text = artikl.naziv;
                cbKategorija.SelectedItem = artikl.kategorija;
                cbDobavljac.SelectedItem = entities.Dobavljacs.Local.Where(x => x.id == artikl.dobavljacId).FirstOrDefault();
                numCijena.Value = artikl.ArtiklCijenas.OrderByDescending(x => x.vrijediOd).FirstOrDefault().cijena;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(tbNaziv.Text != "")
            {
                if(vrstaOperacije == VrstaOperacije.Dodavanje)
                {
                    artikl = new Artikl { id = long.Parse(tbSifra.Text), naziv = tbNaziv.Text, kategorija = cbKategorija.SelectedValue.ToString(), dobavljacId = (cbDobavljac.SelectedValue as Dobavljac).id };
                    entities.Artikls.Add(artikl);
                    entities.SaveChanges();

                    artiklCijena = new ArtiklCijena { artiklId = artikl.id, cijena = numCijena.Value, vrijediOd = DateTime.Now };
                    entities.ArtiklCijenas.Add(artiklCijena);
                    entities.SaveChanges();
                }
                if(vrstaOperacije == VrstaOperacije.Azuriranje)
                {
                    artikl.naziv = tbNaziv.Text;
                    artikl.kategorija = cbKategorija.SelectedValue.ToString();
                    artikl.dobavljacId = (cbDobavljac.SelectedValue as Dobavljac).id;
                    entities.SaveChanges();

                    artiklCijena = new ArtiklCijena { artiklId = artikl.id, cijena = numCijena.Value, vrijediOd = DateTime.Now};
                    entities.ArtiklCijenas.Add(artiklCijena);
                    entities.SaveChanges();
                }
            }
            
        }

        private void btnGenerirajSifru_Click(object sender, EventArgs e)
        {
            tbSifra.Text = Generator.GenerirajBarkod().ToString();
        }
    }
}
