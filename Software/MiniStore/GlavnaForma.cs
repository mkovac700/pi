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
    public partial class GlavnaForma : Form
    {
        Trgovina trenutnaTrgovina;
        int trenutnaTrgovinaId;

        string fileLocation;

        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnUpravljanjeArtiklima_Click(object sender, EventArgs e)
        {
            FormUpravljanjeArtiklima formUpravljanjeArtiklima = new FormUpravljanjeArtiklima();
            formUpravljanjeArtiklima.Show();
        }

        private void btnZaprimanjeArtikala_Click(object sender, EventArgs e)
        {
            FormZaprimanjeArtikala formZaprimanjeArtikala = new FormZaprimanjeArtikala();
            formZaprimanjeArtikala.Show();
        }

        private void btnNarucivanjeArtikala_Click(object sender, EventArgs e)
        {
            FormNarucivanjeArtikala formNarucivanjeArtikala = new FormNarucivanjeArtikala();
            formNarucivanjeArtikala.TrgovinaId = trenutnaTrgovinaId;
            formNarucivanjeArtikala.Show();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            FormIzradaRacuna formIzradaRacuna = new FormIzradaRacuna();
            formIzradaRacuna.TrgovinaId = trenutnaTrgovinaId;
            formIzradaRacuna.Show();
        }

        private void btnInventura_Click(object sender, EventArgs e)
        {

            FormInventura formInventura = new FormInventura();
            formInventura.Show();
        }

        private void btnStatistikaProdaje_Click(object sender, EventArgs e)
        {
            FormStatistikaProdaje formStatistikaProdaje = new FormStatistikaProdaje();
            formStatistikaProdaje.TrgovinaId = trenutnaTrgovinaId;
            formStatistikaProdaje.Show();
        }

        private void btnUpravljanjeSatnicom_Click(object sender, EventArgs e)
        {
            FormUpravljanjeSatnicom formUpravljanjeSatnicom = new FormUpravljanjeSatnicom();
           formUpravljanjeSatnicom.Show();
        }

        private void btnIzradaPovratnice_Click(object sender, EventArgs e)
        {
            FormIzradaPovratnice formIzradaPovratnice = new FormIzradaPovratnice();
            formIzradaPovratnice.Show();
        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            FormPostavke formPostavke = new FormPostavke(); 
            formPostavke.Show();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            if (Autentifikator.DohvatiPrijavljenogKorisnika() != null) {
                trenutnaTrgovina = Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault();
                if (trenutnaTrgovina != null)
                {
                    trenutnaTrgovinaId = trenutnaTrgovina.id;
                    lblPoslovnica.Text = $"Poslovnica: {trenutnaTrgovina.oznaka}";
                }
                else
                {
                    lblPoslovnica.Text = $"Poslovnica: nema";
                }
                
                lblKorisnik.Text = $"Korisnik: {Autentifikator.DohvatiPrijavljenogKorisnika().ime} {Autentifikator.DohvatiPrijavljenogKorisnika().prezime}";

                PostaviGumbove();

                UcitajLogo();
            } 
           
        }

        private void UcitajLogo()
        {
            fileLocation = Properties.Settings.Default.FileString;
            if (fileLocation != "")
            {
                try
                {
                    Image image = Image.FromFile(Properties.Settings.Default.FileString);
                    this.BackgroundImage = image;
                }
                catch (System.IO.FileNotFoundException)
                {
                    var result = MessageBox.Show("Neuspješno učitavanje slike! Želite li obrisati sliku?", "Greška", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Properties.Settings.Default.Reset();
                    }
                }
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Autentifikator.OdjaviKorisnika();
            
            this.Close();
        }

        private void timerTrenutnoVrijeme_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMM yyyy. HH:mm:ss");
        }

        private void PostaviGumbove()
        {
            foreach(var control in tbpGumbi.Controls)
            {
                (control as Button).Enabled = false;
            }
            
            int razina = Autentifikator.DohvatiRazinuPrijavljenogKorisnika();

            if(razina <= 3) //zaposlenik
            {
                btnRacun.Enabled = true;
                btnNarucivanjeArtikala.Enabled = true;
                btnZaprimanjeArtikala.Enabled = true;
                btnIzradaPovratnice.Enabled = true;
                btnUpravljanjeSatnicom.Enabled = true;
                btnPostavke.Enabled = true;
            }
            if(razina <= 2) //voditelj
            {
                btnUpravljanjeArtiklima.Enabled = true; 
                btnInventura.Enabled = true;
                btnStatistikaProdaje.Enabled = true;
            }
            if (razina == 1) //admin
            {
                //postavke + upravljanje artiklima (enableano i voditelju)
            }
        }
    }
}
