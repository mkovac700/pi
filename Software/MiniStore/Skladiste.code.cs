﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public partial class Skladiste
    {
        public override string ToString()
        {
            return $"{id} ({Trgovina})";
        }
    }
}
