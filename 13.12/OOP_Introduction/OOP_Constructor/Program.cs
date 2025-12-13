
using OOP_Constructor;

//Constructor: bir sınıfın bir örneğinin alımı esnasında ilk tetiklenen metotdur.

Bebek bebek1 = new Bebek();
//bebek1.DogumTarihi=DateTime.Now;


Bebek bebek2 = new Bebek("Fatma");
//bebek2.DogumTarihi = DateTime.Now;

Bebek bebek3 = new Bebek("Fatma","Murat");
//bebek3.DogumTarihi = DateTime.Now;

Bebek bebek4 = new Bebek
{
    AnneAd = "Zeynep",
    BabaAd = "Hasan",
    DogumTarihi = DateTime.Now,
};

Console.Read();