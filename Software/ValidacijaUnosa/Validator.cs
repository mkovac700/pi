using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacijaUnosa
{
    public static class Validator
    {
        public static bool ProvjeriSifruArtikla(string unos)
        {
            int privremeno;

            if (!int.TryParse(unos, out privremeno))
            {
                return false;
            }

            return true;
        }
    }
}
