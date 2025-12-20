using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani
{
    internal class Siparis
    {
        public Musteri Musteri { get; set; }
        public List<SiparisKalemi> Kalemler { get; set; } = new List<SiparisKalemi>();

        public decimal ToplamTutar()
        {
            decimal toplam = 0;
            foreach (var kalem in Kalemler)
                toplam += kalem.ToplamTutar();
            return toplam;
        }

        public void SiparisTemizle()
        {
            Kalemler.Clear();
        }

        public void UrunBazliTutarYazdir()
        {
            Console.WriteLine("\n--- Ürün Bazlı Tutarlar ---");
            foreach (var kalem in Kalemler)
            {
                Console.WriteLine($"{kalem.Kahve.Ad} x {kalem.Adet} = {kalem.ToplamTutar()} TL");
            }
            Console.WriteLine("---------------------------\n");
        }


    }
}
