using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public partial class Artikl
    {
        public decimal RelevantnaCijena
        {
            get { return ArtiklCijenas.OrderByDescending(x => x.vrijediOd).FirstOrDefault().cijena; }
        }

        public override string ToString()
        {
            return naziv;
        }
    }
}
