using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani
{
    internal class Espresso:Kahve
    {
        public Espresso() : base("Espresso", 125) { }
        public override void Hazirla()
        {
            Console.WriteLine("Espresso hazırlanıyor...");
        }

    }
}
