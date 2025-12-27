using Microsoft.AspNetCore.Mvc;
using MVC_Coffee.Data;
using MVC_Coffee.Models.Entities;
using MVC_Coffee.Models.Entities.Enums;

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

        [HttpPost]
        public IActionResult SelectSize(int id, CoffeeSize size)
        {
            return View();
        }
    }
}
