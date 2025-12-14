using OOP_FutbolTakim.Abstracts;
using OOP_FutbolTakim.Concretes;

//List
List<Futbolcu> futbolTakimi=new List<Futbolcu>();

//Kaleci
Kaleci kaleci=new Kaleci();
kaleci.Ad = "Altay";
kaleci.Soyad = "Bayındır";

//Defans
Defans defans=new Defans();
defans.Ad = "Davidson";
defans.Soyad = "Sanchez";

//OrtaSaha
OrtaSaha ortaSaha=new OrtaSaha();
ortaSaha.Ad = "Arda";
ortaSaha.Soyad = "Güler";

//Forvet
Forvet forvet=new Forvet();
forvet.Ad = "Kylian";
forvet.Soyad = "Mbappe";

//Futbolcuların Kadroya dahil edilmesi
futbolTakimi.Add(kaleci);
futbolTakimi.Add(defans);
futbolTakimi.Add(ortaSaha);
futbolTakimi.Add(forvet);

//Uygulama çalıştığında Kaleci degaj ile birlikte başlasın. Orta saha oyun kursun. Forvet ileri koşu yapsın.

foreach(Futbolcu futbolcu in futbolTakimi)
{
    //Kaleci
    if(futbolcu is Kaleci)
    {
        
        Kaleci kaleci1 = (Kaleci)futbolcu;
        Console.WriteLine(kaleci1.Degaj());
        Console.WriteLine(futbolcu.SutGuc);
        Console.WriteLine(futbolcu.PasGuc);

    }

    //Defans

    //Ortasaha
    if (futbolcu is OrtaSaha)
    {
        OrtaSaha ortaSaha1 = (OrtaSaha)futbolcu;
        Console.WriteLine(ortaSaha1.OyunKur());
    }

    //Forvet
    if (futbolcu is Forvet)
    {
        Forvet forvet1 = (Forvet)futbolcu;
        Console.WriteLine(forvet1.IleriKosu());
    }
}