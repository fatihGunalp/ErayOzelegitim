using Microsoft.AspNetCore.Mvc;
using MVC_CoffeeApplication.Models.Context;
using MVC_CoffeeApplication.Repositories.Abstracts;

namespace MVC_CoffeeApplication.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        ////CategoryController DbContext'e bağımlı. (Dependency Injection)
        //private CoffeeContext _context;
        //public CategoryController(CoffeeContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            //var categories = _context.Categories.ToList();
            //return View(categories);
            var categories = _categoryRepository.GetAllCategories();
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
