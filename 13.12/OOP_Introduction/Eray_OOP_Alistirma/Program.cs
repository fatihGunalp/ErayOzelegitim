using Eray_OOP_Alistirma;

Ogrenci ogrenci1 = new Ogrenci("Murat", 15, "O123");
Ogretmen ogretmen1 = new Ogretmen("Mehmet", 49, "Matematik");

ogrenci1.Tanit();
ogretmen1.Tanit();

ogrenci1.Dersler.Add("Matematik");
ogrenci1.Dersler.Add("Fizik");
ogrenci1.DersleriGoster();

Console.ReadLine();
