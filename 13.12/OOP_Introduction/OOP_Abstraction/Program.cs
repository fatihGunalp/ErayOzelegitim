
using OOP_Abstraction;

Laptop laptop = new Laptop();
laptop.ProductName = "Lenovo";
laptop.UnitPrice = 10000;

MobilePhone phone = new MobilePhone();
phone.ProductName = "Iphone";
phone.UnitPrice = 80000;

Console.WriteLine(laptop.ProductDetails());
Console.WriteLine(phone.ProductDetails());

//Product product = new Product();

//Abstraction: Soyutlama
//1-Eğer bir nesneyi abstract olarak işaretlersek o nesnenin örneği alınamaz.
//2-Eğer bir property ya da metodu abstract olarak işaretlersek miras verilen class içerisinde onu ezmek ZORUNDAYIZ!
//3-Abstract olarak işaretlenen bir class ya da özellike/eylem static olamazlar.