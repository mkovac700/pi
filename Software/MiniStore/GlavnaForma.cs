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
        public int KorisnikId { get; set; } = 1;
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
           
            using (var db = new Database())
            {
                var trenutniKorisnik = db.Korisniks.Include("Trgovinas").FirstOrDefault((k) => k.id == KorisnikId);

                if (trenutniKorisnik != null) {
                    var trenutnaTrgovina = trenutniKorisnik.Trgovinas.ToList().First();
                    trenutnaTrgovinaId = trenutnaTrgovina.id;

                    lblPoslovnica.Text = $"Poslovnica: {trenutnaTrgovina.oznaka}";
                }
            }
           
        }

        
    }
}
