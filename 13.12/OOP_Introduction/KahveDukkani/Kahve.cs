using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani
{
    abstract class Kahve
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public Kahve(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public abstract void Hazirla();

    }
}
