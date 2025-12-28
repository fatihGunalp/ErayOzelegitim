namespace MVC_CoffeeApplication.ViewModels
{
    public class CoffeeViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string BeanOrigin { get; set; }
        public decimal Price { get; set; }
        public CoffeeSize Size { get; set; }

    }

    public enum CoffeeSize
    {
        Small,
        Medium,
        Large,
    }
}
