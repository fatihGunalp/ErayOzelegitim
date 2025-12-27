namespace MVC_Coffee.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Coffee> Coffees { get; set; } = new();
    }
}
