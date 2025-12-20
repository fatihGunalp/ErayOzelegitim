using KahveDukkani;
using System;
using System.Collections.Generic;

namespace KahveSiparisUygulamasi
{
    class KahveDukkaniUygulamasi
    {
        static void Main(string[] args)
        {
            
            List<Kahve> menu = new List<Kahve>()
            {
                new FiltreKahve(),
                new Americano(),
                new Espresso()
            };

            Siparis siparis = new Siparis();

            while (true)
            {
                Console.WriteLine("Menü:");
                for (int i = 0; i < menu.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i].Ad} - {menu[i].Fiyat} TL");
                }

                Console.Write("Seçim: ");
                int secim = int.Parse(Console.ReadLine());

                Console.Write("Adet: ");
                int adet = int.Parse(Console.ReadLine());

                Kahve kahve = menu[secim - 1];
                siparis.Kalemler.Add(new SiparisKalemi(kahve, adet));

                Console.Write("Ad: ");
                string ad = Console.ReadLine();
                Console.Write("Soyad: ");
                string soyad = Console.ReadLine();
                Console.Write("Adres: ");
                string adres = Console.ReadLine();

                siparis.Musteri = new Musteri { Ad = ad, Soyad = soyad, Adres = adres };

                kahve.Hazirla();
                Console.WriteLine($"Siparişiniz oluşturuldu. Toplam Tutar: {siparis.ToplamTutar()} TL");

                siparis.UrunBazliTutarYazdir();


                Console.Write("Yeni sipariş oluştur (e/h): ");
                string cevap = Console.ReadLine();

                if (cevap.ToLower() == "e")
                {
                    
                    Console.WriteLine("Yeni sipariş eklenecek. Mevcut sipariş korunuyor.");
                }
                else if (cevap.ToLower() == "h")
                {
                    siparis.SiparisTemizle();

                    Console.WriteLine("Sipariş korunuyor, menü tekrar gösterilecek.");
                }
            }
        }
    }
}