using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public class StatistikaProdajeArtikl
    {
        public string NazivProizvoda { get; set; }
        public long? SifraProizvoda { get; set; }
        public string Kategorija { get; set; }
        public int? VolumenProdaje { get; set; }
        public decimal? ProdanaVrijednost { get; set; }
        public List<StatistikaProdajeArtiklStavkaVrijeme> ProdajaPoKvartaluVrijeme { get; set; }
        public List<StatistikaProdajeArtiklStavkaTrgovina> ProdajaPoKvartaluTrgovina { get; set; }

    }
    public class StatistikaProdajeArtiklStavkaVrijeme
    {

        public DateTime? DatumRacuna { get; set; }
        public int? VolumenProdaje { get; set; }

    }
    public class StatistikaProdajeArtiklStavkaTrgovina
    {

        public string NazivTrgovine { get; set; }
        public int? VolumenProdaje { get; set; }

    }
}
