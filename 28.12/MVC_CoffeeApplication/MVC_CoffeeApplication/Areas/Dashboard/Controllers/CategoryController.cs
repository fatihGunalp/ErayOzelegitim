using Microsoft.AspNetCore.Mvc;
using MVC_CoffeeApplication.Models.Context;

namespace MVC_CoffeeApplication.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {

        //CategoryController DbContext'e bağımlı. (Dependency Injection)
        private CoffeeContext _context;
        public CategoryController(CoffeeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Oluşturma
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            //Güncelleme işlemi
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //silme
            return View();
        }
    }
}
