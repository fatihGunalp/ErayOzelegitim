using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eray_OOP_Alistirma
{
    internal class Ogretmen:Kisi
    {
        public string Brans { get; set; }

        public Ogretmen(string ad, int yas, string brans)
        {
            Ad = ad;
            Yas = yas;
            Brans = brans;
        }

        public override void Tanit()
        {
            Console.WriteLine("Benim adım " + Ad + ", " + Yas + " yaşındayım. Branşım: " + Brans);
        }



    }
}
