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
            var odabranaKategorija = cbKategorija.SelectedItem as string;
            FormStatistikaProdajeKategorijazvjestaj f = new FormStatistikaProdajeKategorijazvjestaj();
            using (var db = new Database())
            {

                f.Podaci = new StatistikaProdajeKategorija
                {
                    NazivKategorija = odabranaKategorija,

                    VolumenProdaje = db.RacunArtikls.Include("Artikl").Where(p => p.Artikl.kategorija == odabranaKategorija).Sum(p => p.kolicina),
                    ProdanaVrijednost = db.RacunArtikls.Include("Artikl").Where(p => p.Artikl.kategorija == odabranaKategorija).Sum(p => p.kolicina * p.cijena),
                    ProdajaPoKvartaluTrgovina = db.RacunArtikls.Include("Racun").Include("Artikl").Where(p => p.Artikl.kategorija == odabranaKategorija).Select(z => new StatistikaProdajeKategorijaStavkaTrgovina
                    {
                        NazivTrgovine = z.Racun.Trgovina.oznaka,
                        VolumenProdaje = z.kolicina,
                    }).ToList(),
                    ProdajaPoKvartaluVrijeme = db.RacunArtikls.Include("Racun").Include("Artikl").Where(p => p.Artikl.kategorija == odabranaKategorija).Select(z => new StatistikaProdajeKategorijaStavkaVrijeme
                    {
                        DatumRacuna = z.Racun.datumVrijeme,
                        VolumenProdaje = z.kolicina,
                    }).ToList(),
                };

            }

            f.ShowDialog();

        }

        private void btnIzvjesceUkupnogPoslovanja_Click(object sender, EventArgs e)
        {
            FormStatistikaProdajeUkupnoPoslovanjeIzvjestaj f = new FormStatistikaProdajeUkupnoPoslovanjeIzvjestaj();
            using (var db = new Database())
            {

                List<StatistikaProdajeUkupnoArtikli> artikliSum = new List<StatistikaProdajeUkupnoArtikli>();
                List<StatistikaProdajeUkupnoKategorije> kategorijeSum = new List<StatistikaProdajeUkupnoKategorije>();
                List<string> sveKategorije = new List<string>();
                foreach (var item in db.Artikls)
                {
                    sveKategorije.Add(item.kategorija);
                    artikliSum.Add(new StatistikaProdajeUkupnoArtikli
                    {

                        NazivArtikla = item.naziv,

                        VolumenProdaje = db.RacunArtikls.Include("Artikl").Where(p => p.artiklId == item.id).Sum(p => p.kolicina)
                    }); ;
                }
                foreach (var item in sveKategorije.Distinct())
                {
                    kategorijeSum.Add(new StatistikaProdajeUkupnoKategorije
                    {
                        NazivKategorije = item,
                        VolumenProdaje = db.RacunArtikls.Include("Artikl").Where(p => p.Artikl.kategorija == item).Sum(p => p.kolicina)

                    });
                }

                f.Podaci = new StatistikaProdajeUkupnoPoslovanje
                {
                    ProdajaArtikala = artikliSum.Where(p=>p.VolumenProdaje > 0).ToList(),
                    ProdajaKategorija = kategorijeSum.Where(p=>p.VolumenProdaje >0).ToList(),

                };


            }
            f.ShowDialog();
        }

        private void FormStatistikaProdaje_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help/help-statistika.chm");

        }

        private void FormStatistikaProdaje_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Help/help-statistika.chm");
        }
    }
}

