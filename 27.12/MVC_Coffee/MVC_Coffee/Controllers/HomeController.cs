using Microsoft.AspNetCore.Mvc;
using MVC_Coffee.Data;
using MVC_Coffee.Models.Entities;
using MVC_Coffee.Models.Entities.Enums;
using MVC_Coffee.ViewModels;

namespace MVC_Coffee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Kahve menüsünü anasayfada listelenmesi gerekiyor.

           var coffees= SeedCoffeeData.coffees;

            ViewBag.Cart = CartData.coffees;
            ViewBag.Orders = OrderData.Orders;

          

            return View(coffees);
        }

        [HttpPost]
        public IActionResult SelectSize(int id, CoffeeSize size)
        {
            //parametreden gelen Id ve size değerlerini alarak sepet içerisinde kahve oluşturulacak.
            var coffee = SeedCoffeeData.coffees.FirstOrDefault(x => x.ID == id);
            if (coffee != null)
            {
                CartViewModel cartViewModel = new CartViewModel
                {
                    CoffeeId = coffee.ID,
                    Name = coffee.Name,
                    Size = size.ToString(),
                    Price = coffee.GetPrice(size)
                };

                CartData.coffees.Add(cartViewModel);

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

            
        }
    }
}
