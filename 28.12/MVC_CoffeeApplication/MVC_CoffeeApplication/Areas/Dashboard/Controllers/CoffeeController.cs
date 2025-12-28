using Microsoft.AspNetCore.Mvc;
using MVC_CoffeeApplication.Repositories.Abstracts;

namespace MVC_CoffeeApplication.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CoffeeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }
        public IActionResult Index()
        {
            //Coffee List
            var coffees = _coffeeRepository.GetAllCoffees();
            return View(coffees);
        }
    }
}
