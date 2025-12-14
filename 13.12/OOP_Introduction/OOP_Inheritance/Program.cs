using OOP_Inheritance;


//Nesne Listesi
List<object> list = new List<object>();

List<BaseClass> urunler = new List<BaseClass>();

//ekran kartları: List


List<EkranKart> ekranKartlari=new List<EkranKart>();

//anakartlar: List
List<Anakart> anakartlar=new List<Anakart>();

//islemciler: List
List<Islemci> islemciler=new List<Islemci>();

//Bilgisayarlar: List
List<Bilgisayar> bilgisayarlar=new List<Bilgisayar>();


//ekran kart 1
EkranKart ekranKart=new EkranKart();
ekranKart.ID = 1;
ekranKart.Marka = "Nvidia";
ekranKart.Model = "RTX 5090";
ekranKart.Fiyat = 60000;

//ekran kart 2
EkranKart ekranKart2 = new EkranKart();
ekranKart2.ID = 2;
ekranKart2.Marka = "Asus";
ekranKart2.Model = "RTX 4060";
ekranKart2.Fiyat = 30000;

ekranKartlari.Add(ekranKart);
ekranKartlari.Add(ekranKart2);
//


//anakart 1
Anakart anakart = new Anakart();
anakart.ID = 1;
anakart.Marka = "Asus";
anakart.Model = "Asus-B";
anakart.Fiyat = 10000;

//anakart 2
Anakart anakart2 = new Anakart();
anakart2.ID = 2;
anakart2.Marka = "Msi";
anakart2.Model = "Msi-B";
anakart2.Fiyat = 15000;

anakartlar.Add(anakart);
anakartlar.Add(anakart2);

//İslemci 1
Islemci islemci1 = new Islemci
{
    ID = 1,
    Marka = "Intel",
    Model = "I7",
    Fiyat = 20000
};
//İslemci 2

Islemci islemci2 = new Islemci
{
    ID = 2,
    Marka = "Amd",
    Model = "Ryzen 5",
    Fiyat = 17000
};



islemciler.Add(islemci1);
islemciler.Add(islemci2);

//object list
list.Add(anakart);
list.Add(anakart2);
list.Add(islemci1);
list.Add(islemci2);
list.Add(ekranKart);
list.Add(ekranKart2);

urunler.Add(anakart);
urunler.Add(anakart2);
urunler.Add(islemci1);
urunler.Add(islemci2);
urunler.Add(ekranKart);
urunler.Add(ekranKart2);



#region Örnek 1
////ilk bilgisayarın anakartı asus, ekran kartı nvidia, islemci intel I7 olsun.

//Bilgisayar pc1 =new Bilgisayar();
//pc1.ID = 1;
//pc1.Anakart = anakart;
//pc1.EkranKart = ekranKart;
//pc1.Islemci = islemci1;

////ikinci bilgisayarın anakartı msi, ekran kartı asus, islemci AMD Ryzen 5

//Bilgisayar pc2 = new Bilgisayar();
//pc1.ID = 2;
//pc2.Anakart = anakart2;
//pc2.EkranKart = ekranKart2;
//pc2.Islemci = islemci2;

////iki adet bilgisayar tek bir çatı altına alınsın.

//bilgisayarlar.Add(pc1);
//bilgisayarlar.Add(pc2);

////Bilgisayarların özelliklerini console'da göster.
//foreach (Bilgisayar pc in bilgisayarlar)
//{
//    Console.WriteLine($"Anakart: {pc.Anakart.Marka} Ekrankart: {pc.EkranKart.Marka} Islemci: {pc.Islemci.Marka}");
//} 
#endregion

//oluşturulan bütün referans değerler tek bir liste içerisine alınabilir mi?

//list içerisinde dön sadece ekran kartları'nın marka ve modellerini console'da yazdır.

//foreach (var item in list)
//{
//    if(item is EkranKart)
//    {
//        //cast
//        EkranKart gelenEkranKarti= (EkranKart)item;
//        Console.WriteLine($"Marka: {gelenEkranKarti.Marka} Model: {gelenEkranKarti.Model}");
//    }
//}


foreach(BaseClass item in urunler)
{
    //Anakart
    if(item is Anakart)
    {
        Anakart gelenAnakart= (Anakart)item;
        Console.WriteLine($"Anakart Özellikleri:\nMarka: {gelenAnakart.Marka} Model: {gelenAnakart.Model} Fiyat: {gelenAnakart.Fiyat}");
    }

    //Islemci
    if (item is EkranKart)
    {
        EkranKart gelenEkranKart = (EkranKart)item;
        Console.WriteLine($"Ekran Kart Özellikleri:\nMarka: {gelenEkranKart.Marka} Model: {gelenEkranKart.Model} Fiyat: {gelenEkranKart.Fiyat}");
    }
    //EkranKarti
    if (item is Islemci)
    {
        Islemci gelenIslemci = (Islemci)item;
        Console.WriteLine($"İşlemci Özellikleri:\nMarka: {gelenIslemci.Marka} Model: {gelenIslemci.Model} Fiyat: {gelenIslemci.Fiyat}");
    }
    //Bilgisayar
    if (item is Bilgisayar)
    {
        Bilgisayar gelenBilgisayar = (Bilgisayar)item;
        Console.WriteLine($"Bilgisayar Özellikleri:\nAnakart: {gelenBilgisayar.Anakart} Ekran Karti: {gelenBilgisayar.EkranKart} İslemci: {gelenBilgisayar.Islemci}");
    }
}