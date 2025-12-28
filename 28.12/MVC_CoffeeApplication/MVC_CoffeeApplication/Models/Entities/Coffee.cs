namespace MVC_CoffeeApplication.Models.Entities
{
    public class Coffee
    {
        public int ID { get; set; }
        public string BeanOrigin { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<CoffeeSize> CoffeeSizes { get; set; }

    }
}
