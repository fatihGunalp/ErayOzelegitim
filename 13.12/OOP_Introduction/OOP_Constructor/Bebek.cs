namespace OOP_Constructor
{
    internal class Bebek
    {
        //her class içerisinde constructor mevcuttur ancak o constructor'ı ezmek istediğimizde manuel olarak (gövdesini açmamız) oluşturmamız gerekmektedir.


        //constuctor

        public Bebek()
        {
            DogumTarihi=DateTime.Now;
        }

        public Bebek(string anneAd)
        {
            DogumTarihi = DateTime.Now;
            AnneAd = anneAd;
        }

        public Bebek(string anneAd, string babaAd)
        {
            DogumTarihi = DateTime.Now;
            AnneAd = anneAd;
            BabaAd = babaAd;
        }

        public string AnneAd { get; set; }
        public string BabaAd { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
