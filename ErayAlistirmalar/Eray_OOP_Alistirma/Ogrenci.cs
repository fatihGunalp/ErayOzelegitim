using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eray_OOP_Alistirma
{
    internal class Ogrenci:Kisi
    {
        public string Numara { get; set; }
        public List<string> Dersler { get; set; }
        public Ogrenci(string ad, int yas, string numara)
        {
            Ad = ad;
            Yas = yas;
            Numara = numara;
            Dersler = new List<string>();
        }

        public override void Tanit()
        {
            Console.WriteLine("Benim adım " + Ad + ", " + Yas + " yaşındayım. Numaram: " + Numara);
        }
        public void DersleriGoster()
        {
            Console.WriteLine(Ad + " adlı öğrencinin dersleri:");
            foreach (var ders in Dersler)
            {
                Console.WriteLine("- " + ders);
            }
        }




    }
}
