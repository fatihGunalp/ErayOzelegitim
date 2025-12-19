using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani
{
    internal class FiltreKahve:Kahve
    {
        public FiltreKahve() : base("Filtre Kahve", 100) { }
        public override void Hazirla()
        {
            Console.WriteLine("Filtre kahve hazırlanıyor...");
        }

    }
}
