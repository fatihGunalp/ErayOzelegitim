namespace MVC_Coffee.Models.Entities
{
    public abstract class Coffee //BaseClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
