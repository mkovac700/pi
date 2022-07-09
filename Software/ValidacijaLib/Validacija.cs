using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacijaLib
{
    public static class Validacija
    {
        public static bool ProvjeriUnosBroja(string unos)
        {
            return long.TryParse(unos, out long result);
        }
    }
}
