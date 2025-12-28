namespace MVC_CoffeeApplication.Models.Entities
{
    public class CoffeeSize
    {
        public int CoffeeId { get; set; }
        public int SizeId { get; set; }

        public Coffee Coffee { get; set; }
        public Size Size { get; set; }
    }
}
