using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani
{
    internal class Americano:Kahve
    {
        public Americano() : base("Americano", 120) { }
        public override void Hazirla()
        {
            Console.WriteLine("Americano hazırlanıyor...");
        }

    }
}
