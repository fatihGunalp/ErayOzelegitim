namespace MVC_CoffeeApplication.Models.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public List<Coffee> Coffees { get; set; }
    }
}
