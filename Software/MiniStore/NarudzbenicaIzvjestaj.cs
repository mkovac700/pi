using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public class NarudzbenicaIzvjestaj
    {
        public string NazivTrgovine { get; set; }
        public string AdresaTrgovine { get; set; }
        public string NazivDobavljaca { get; set; }
        public string AdresaDobavljaca { get; set; }
        public DateTime? DatumNarudzbenice { get; set; }
        public string ImeKorisnika { get; set; }
        public List<NarudzbenicaIzvjestajStavka> Artikli { get; set; }


    }

    public class NarudzbenicaIzvjestajStavka
    {

        public string NazivArtikla { get; set; }
        public int? Kolicina { get; set; }
    }
}

