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
    public partial class FormSatnica : Form
    {
        private VrstaOperacije vrstaOperacije;
        private Korisnik korisnik;
        public Satnica satnica;
        Database entities = new Database();

        public FormSatnica(VrstaOperacije vrstaOperacije, Korisnik korisnik)
        {
            InitializeComponent();
            this.vrstaOperacije = vrstaOperacije;
            this.korisnik = korisnik;
            satnica = new Satnica();
            SetMyCustomFormat();
            entities.Satnicas.Load();
        }

        public FormSatnica(VrstaOperacije vrstaOperacije, Korisnik korisnik, Satnica satnica)
        {
            InitializeComponent();
            this.vrstaOperacije = vrstaOperacije;
            this.korisnik = korisnik;
            this.satnica = satnica;
            SetMyCustomFormat();
            entities.Satnicas.Load();
        }

        private void SetMyCustomFormat()
        {
            dtpDatum.CustomFormat = "dd MMMM yyyy";
        }

        private void FormSatnica_Load(object sender, EventArgs e)
        {
            lblKorisnik.Text = korisnik.ToString(); 

            if(vrstaOperacije == VrstaOperacije.Azuriranje)
            {
                dtpDatum.Value = (DateTime)satnica.datum;
                numSati.Value = (decimal)satnica.brojSati;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(vrstaOperacije == VrstaOperacije.Dodavanje)
            {
                satnica.korisnikId = korisnik.id;
                satnica.datum = dtpDatum.Value.Date;
                satnica.brojSati = (int)numSati.Value;

                if (satnica.datum.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Nije moguće dodati datum u budućnosti!");
                    return;
                }
                else if (entities.Satnicas.FirstOrDefault(x => x.datum == satnica.datum && x.korisnikId == satnica.korisnikId) != null)
                {
                    MessageBox.Show("Zapis s tim datumom već postoji. Kontaktirajte voditelja poslovnice za izmjenu ili odaberite drugi datum!");
                    return;
                }
                else
                {
                    entities.Satnicas.Add(satnica);
                    entities.SaveChanges();
                    this.Close();
                }
            }

            if(vrstaOperacije == VrstaOperacije.Azuriranje)
            {
                var postojecaSatnica = entities.Satnicas.Find(satnica.id);
                postojecaSatnica.datum = dtpDatum.Value.Date;
                postojecaSatnica.brojSati = (int)numSati.Value;
                entities.SaveChanges();
                this.Close();
            }
            
        }
    }
}
