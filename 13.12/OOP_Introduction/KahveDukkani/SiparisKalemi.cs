using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani
{
    internal class SiparisKalemi
    {
        public Kahve Kahve { get; set; }
        public int Adet { get; set; }

        public SiparisKalemi(Kahve kahve, int adet)
        {
            Kahve = kahve;
            Adet = adet;
        }

        public decimal ToplamTutar()
        {
            return Kahve.Fiyat * Adet;
        }

    }
}
