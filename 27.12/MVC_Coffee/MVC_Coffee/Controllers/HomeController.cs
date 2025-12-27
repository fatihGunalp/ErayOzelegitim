using Microsoft.AspNetCore.Mvc;
using MVC_Coffee.Data;

namespace MVC_Coffee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Kahve menüsünü anasayfada listelenmesi gerekiyor.

           var coffees= SeedCoffeeData.coffees;

            return View(coffees);
        }
    }
}
