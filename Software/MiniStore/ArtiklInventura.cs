using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public class ArtiklInventura
    {
        public long artiklId { get; set; }
        public decimal jedinicnaCijena { get; set; }
        public int kolicina { get; set; }

        public ArtiklInventura(long artiklid, decimal jedinicnacijena, int kolicina)
        {
            this.artiklId = artiklid;
            this.jedinicnaCijena = jedinicnacijena;
            this.kolicina = kolicina;
        }
    }
}
