using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public class StatistikaProdajeUkupnoPoslovanje
    {

        public List<StatistikaProdajeUkupnoArtikli> ProdajaArtikala { get; set; }
        public List<StatistikaProdajeUkupnoKategorije> ProdajaKategorija { get; set; }
    }


    public class StatistikaProdajeUkupnoKategorije
    {
        public int? VolumenProdaje { get; set; }
        public string NazivKategorije { get; set; }

    }

    public class StatistikaProdajeUkupnoArtikli
    {
        public string NazivArtikla { get; set; }
        public int? VolumenProdaje { get; set; }

    }
}
