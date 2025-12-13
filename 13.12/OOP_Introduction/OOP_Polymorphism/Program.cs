using OOP_Polymorphism;

Kus kus = new Kus();

Köpek köpek = new Köpek();

Kedi kedi = new Kedi();

Yarasa yarasa = new Yarasa();

Console.WriteLine($"Kuş Sesi: {kus.Sescikar()}");
Console.WriteLine($"Kedi Sesi: {kedi.Sescikar()}");
Console.WriteLine($"Köpek Sesi: {köpek.Sescikar()}");
Console.WriteLine($"Yarasa Sesi: {yarasa.Sescikar()}");




Console.Read();