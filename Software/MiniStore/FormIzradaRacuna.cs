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
    public partial class FormIzradaRacuna : Form
    {
        public int TrgovinaId { get; set; }

        List<RacunArtikl> artikli = new List<RacunArtikl>();
        public FormIzradaRacuna()
        {
            InitializeComponent();
        }

        private void tbSifraArtikla_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            int kolicina = 1;

            var unesenaKolicina = tbKolicina.Text;
            if (unesenaKolicina.Length > 0)
            {
                kolicina = int.Parse(tbKolicina.Text);
            }

            int sifraArtikla = int.Parse(tbSifraArtikla.Text);

            Artikl trenutniArtikl;
            using (var db = new Database())
            {
                 trenutniArtikl = db.Artikls.Include("ArtiklCijenas").FirstOrDefault(a => a.id == sifraArtikla);
            }

            if(trenutniArtikl == null)
            {
                MessageBox.Show("Artikl s tom šifrom ne postoji!");
                return;
            }

            if (artikli.Count(a => a.artiklId == sifraArtikla) > 0)
            {
                artikli.First(a => a.artiklId == sifraArtikla).kolicina += kolicina;
                }
            else
            {
                artikli.Add(new RacunArtikl
                {
                    artiklId = sifraArtikla,
                    kolicina = kolicina,
                    cijena = trenutniArtikl.ArtiklCijenas.OrderBy(c => c.vrijediOd).First().cijena,
                });
            }

            tbKolicina.Clear();
            tbSifraArtikla.Clear();

            OsvjeziDgv();

            
        }

        void OsvjeziDgv()
        {
           using(var db = new Database())
            {
                dgvStavkeRacuna.DataSource = artikli.Select(a => new
                {
                    Naziv = db.Artikls.First(r=> r.id == a.artiklId).naziv,
                    Kolicina = a.kolicina,
                    Cijena = $"{a.cijena:C2}",
                    PDV = "25%",
                    Iznos = $"{((decimal)1.25 * a.cijena * a.kolicina):C2}",
                }).ToList();
            }

            var iznos = artikli.Sum(a => (decimal)1.25 * a.cijena * a.kolicina);

            lblIznos.Text = $"{iznos:C2}";
        }
    }
}
