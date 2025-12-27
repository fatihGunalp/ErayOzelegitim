using MVC_Coffee.Models.Entities.Enums;

namespace MVC_Coffee.Models.Entities
{
    public abstract class Coffee //BaseClass
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        //Ebat,
        public CoffeeSize Size { get; set; }

        //Verilen boyuta göre hesaplama işlemini gerçekleştiren metot.
        public decimal GetPrice(CoffeeSize coffeeSize)
        {
            var basePrice = Price;
            switch (coffeeSize)
            {
                case CoffeeSize.Medium:
                    basePrice *= 1.15m;
                    break;

                case CoffeeSize.Large:
                    basePrice *= 1.30m;
                    break;
            }

            return basePrice;
        }

    }
}