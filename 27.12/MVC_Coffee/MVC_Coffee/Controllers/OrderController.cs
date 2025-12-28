using Microsoft.AspNetCore.Mvc;
using MVC_Coffee.Data;
using MVC_Coffee.Models.Entities;

namespace MVC_Coffee.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create()
        {


            if (CartData.coffees.Count <= 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Order order = new Order
                {
                    Id = OrderData.Orders.Count + 1
                };

                for(int i=0; i<CartData.coffees.Count; i++)
                {
                    var coffee = SeedCoffeeData.coffees.FirstOrDefault(x => x.ID == CartData.coffees[i].CoffeeId);
                    order.Coffees.Add(coffee);
                }

                OrderData.Orders.Add(order);
                CartData.coffees.Clear();
                return RedirectToAction("Index", "Home");

            }

            return View();
        }
    }
}
