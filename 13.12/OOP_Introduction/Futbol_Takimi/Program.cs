using Futbol_Takimi;
using System.ComponentModel;

Futbolcu futbolcu1 = new Futbolcu();
futbolcu1.Ad = "Altay";
futbolcu1.Soyad = "Bayindir";
futbolcu1.FormaNo = 1;
futbolcu1.Mevki = "kaleci";


Console.WriteLine(futbolcu1.Ad +" "+ futbolcu1.Soyad + " Mevki:" + futbolcu1.Mevki + " Sut Gücü: " + futbolcu1.SutGucu("70") + " Pas Gücü: " + futbolcu1.PasGucu("80"));

Futbolcu futbolcu2 = new Futbolcu();
futbolcu2.Ad = "Davinson";
futbolcu2.Soyad = "Sanchez";
futbolcu2.FormaNo = 4;
futbolcu2.Mevki = "Defans";

Console.WriteLine(futbolcu2.Ad + " " + futbolcu2.Soyad + " Mevki:" + futbolcu2.Mevki + " Sut Gücü: " + futbolcu2.SutGucu("78") + " Pas Gücü: " + futbolcu2.PasGucu("85"));


Futbolcu futbolcu3 = new Futbolcu();
futbolcu3.Ad = "Arda";
futbolcu3.Soyad = "Güler";
futbolcu3.FormaNo = 10;
futbolcu3.Mevki = "Orta Saha";

Console.WriteLine(futbolcu3.Ad + " " + futbolcu3.Soyad + " Mevki:" + futbolcu3.Mevki + " Sut Gücü: " + futbolcu3.SutGucu("85") + " Pas Gücü: " + futbolcu3.PasGucu("92"));



Futbolcu futbolcu4 = new Futbolcu();
futbolcu4.Ad = "Victor";
futbolcu4.Soyad = "Osimhen";
futbolcu4.FormaNo = 9;
futbolcu4.Mevki = "Forvet";


Console.WriteLine(futbolcu4.Ad + " " + futbolcu4.Soyad + " Mevki:" + futbolcu4.Mevki + " Sut Gücü: " + futbolcu4.SutGucu("95") + " Pas Gücü: " + futbolcu1.PasGucu("68"));


Console.ReadLine();