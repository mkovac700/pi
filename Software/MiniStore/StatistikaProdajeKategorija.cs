using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public class StatistikaProdajeKategorija
    {
        public string NazivKategorija { get; set; }
        public int? VolumenProdaje { get; set; }
        public decimal? ProdanaVrijednost { get; set; }
        public List<StatistikaProdajeKategorijaStavkaVrijeme> ProdajaPoKvartaluVrijeme { get; set; }
        public List<StatistikaProdajeKategorijaStavkaTrgovina> ProdajaPoKvartaluTrgovina { get; set; }

    }
    public class StatistikaProdajeKategorijaStavkaVrijeme
    {

        public DateTime? DatumRacuna { get; set; }
        public int? VolumenProdaje { get; set; }

    }
    public class StatistikaProdajeKategorijaStavkaTrgovina
    {

        public string NazivTrgovine { get; set; }
        public int? VolumenProdaje { get; set; }

    }
}
