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
            }
            if(razina <= 2) //voditelj
            {
                btnUpravljanjeArtiklima.Enabled = true; //funkcionalnost podijeliti na dvije opcije: voditelj moze obavljati CRUD nad ArtiklSkladiste, dok superuser nad Artikl + ArtiklCijena
                btnInventura.Enabled = true;
                btnStatistikaProdaje.Enabled = true;
                //postavke (dodati gumb)
            }
            if (razina == 1) //admin
            {
                //postavke (dodati gumb)
            }
        }
    }
}
