using Eray_OOP_Alistirma;

Ogrenci ogrenci1 = new Ogrenci("Murat", 15, "O123");
Ogrenci ogrenci2= new Ogrenci("Filiz",16,"9876");
Ogretmen ogretmen1 = new Ogretmen("Mehmet", 49, "Matematik");
Ogretmen ogretmen2 = new Ogretmen("Hasan", 42, "Tarih");

ogrenci1.Tanit();
ogrenci2.Tanit();
ogretmen1.Tanit();
ogretmen2.Tanit();

ogrenci1.Dersler.Add("Matematik");      
ogrenci1.Dersler.Add("Fizik");
ogrenci1.Dersler.Add("Tarih");
ogrenci1.DersleriGoster();

ogrenci2.Dersler.Add("Kimya");
ogrenci2.Dersler.Add("Biyoloji");
ogrenci2.Dersler.Add("Coğrafya");
ogrenci2.DersleriGoster();

Console.ReadLine();
