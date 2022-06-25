using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public class RacunIzvjestaj
    {
        public DateTime? Datum { get; set; }
        public string NacinPlacanja { get; set; }
        public string Blagajnik { get; set; }
        public string NazivTrgovine { get; set; }
        public string AdresaTrgovine { get; set; }
        public List<RacunIzvjestajStavka> Stavke { get; set; }
        public decimal? Iznos { get; set; }
        public decimal? Porez { get; set; }

    }

    public class RacunIzvjestajStavka
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; }
        public int? Kolicina { get; set; }
        public decimal? Cijena { get; set; }
        public string PDV { get; set; }
        public decimal? Iznos { get; set; }
    }
}
