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
    public partial class FormStatistikaProdaje : Form
    {
        public int TrgovinaId { get; set; }
        List<Artikl> artikli = new List<Artikl>();
        List<string> kategorije = new List<string>();
        public FormStatistikaProdaje()
        {
            InitializeComponent();
        }

        private void FormStatistikaProdaje_Load(object sender, EventArgs e)
        {


            using (var db = new Database())
            {
                artikli = db.Artikls.ToList();
                kategorije = artikli.Select(p => p.kategorija).Distinct().ToList();
            }
            cbArtikli.DataSource = artikli;
            cbArtikli.DisplayMember = "naziv";
            cbKategorija.DataSource = kategorije;
        }

        private void btnIzvjesceArtikl_Click(object sender, EventArgs e)
        {
            var odabraniArtikl = cbArtikli.SelectedItem as Artikl;
            FormStatistikaProdajeArtiklIzvjestaj f = new FormStatistikaProdajeArtiklIzvjestaj();
            using (var db = new Database())
            {

                f.Podaci = new StatistikaProdajeArtikl
                {
                    NazivProizvoda = odabraniArtikl.naziv,
                    Kategorija = odabraniArtikl.kategorija,
                    SifraProizvoda = odabraniArtikl.id,
                    VolumenProdaje = db.RacunArtikls.Where(p => p.artiklId == odabraniArtikl.id).Sum(p => p.kolicina),
                    ProdanaVrijednost = db.RacunArtikls.Where(p => p.artiklId == odabraniArtikl.id).Sum(p => p.kolicina * p.cijena),
                    ProdajaPoKvartaluTrgovina = db.RacunArtikls.Include("Racun").Where(p => p.artiklId == odabraniArtikl.id).Select(z => new StatistikaProdajeArtiklStavkaTrgovina
                    {
                        NazivTrgovine = z.Racun.Trgovina.oznaka,
                        VolumenProdaje = z.kolicina,
                    }).ToList(),
                    ProdajaPoKvartaluVrijeme = db.RacunArtikls.Include("Racun").Where(p => p.artiklId == odabraniArtikl.id).Select(z => new StatistikaProdajeArtiklStavkaVrijeme
                    {
                        DatumRacuna = z.Racun.datumVrijeme,
                        VolumenProdaje = z.kolicina,
                    }).ToList(),
                };

            }

            f.ShowDialog();
        }

        private void btnIzvjestajKategorije_Click(object sender, EventArgs e)
        {
            var odabranaKategorija = cbKategorija.SelectedItem;
            FormStatistikaProdajeArtiklIzvjestaj f = new FormStatistikaProdajeArtiklIzvjestaj();

        }
    }
}
