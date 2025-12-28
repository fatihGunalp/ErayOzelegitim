using Microsoft.AspNetCore.Mvc;
using MVC_CoffeeApplication.Models;
using MVC_CoffeeApplication.Repositories.Abstracts;
using MVC_CoffeeApplication.ViewModels;
using System.Diagnostics;

namespace MVC_CoffeeApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICoffeeRepository _coffeeRepository;

        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository, ICoffeeRepository coffeeRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _coffeeRepository = coffeeRepository;
        }

        public IActionResult Index()
        {
            var categories = _categoryRepository.GetAllCategories();
            ViewBag.Categories = categories;


            //var coffeeList = _coffeeRepository.GetAllCoffees()
            //    .Select(x => new CoffeeViewModel
            //    {
            //        Id = x.ID,
            //        Price = x.Price,
            //        CategoryName = categories.FirstOrDefault(p => p.ID == x.CategoryId).CategoryName,
            //        Size=CoffeeSize.Small
            //    });

            List<CoffeeViewModel> coffeeViewModels = new List<CoffeeViewModel>();

           



            return View(coffeeViewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
