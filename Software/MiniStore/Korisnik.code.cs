﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public partial class Korisnik
    {
        public override string ToString()
        {
            return $"{ime} {prezime}";
        }
    }
}
