namespace MVC_CoffeeApplication.Models.Entities
{
    public class Size
    {
        public int Id { get; set; }
        public string SizeName { get; set; }

        public List<CoffeeSize> CoffeeSizes { get; set; }
    }
}
