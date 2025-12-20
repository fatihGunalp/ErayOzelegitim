using AspNetCore_MVC_Controller.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_Controller.Controllers
{
    public class ProductController : Controller
    {
        #region Methods
        //public string Index()
        //{
        //    return "Ürün Listesi";
        //}

        //public string Detail(int id)
        //{
        //    return $"Ürün Detay Id:{id} ";
        //} 
        #endregion

        //List<Product> products = new List<Product>
        //    {
        //        new Product{ID=1,ProductName="Chai",UnitPrice=15},
        //        new Product{ID=2,ProductName="Chang",UnitPrice=25},
        //        new Product{ID=3,ProductName="Ikura",UnitPrice=35},

        //    };

        //Index

        Context _context = new Context();
        public IActionResult Index()
        {

            


            //Model transfer.


            return View(_context.Products.ToList()); //sayfa
        }

        //Detail
        public IActionResult Details(int id)
        {
            //product Detail: 
            var product = _context.Products.FirstOrDefault(x => x.ID == id);
            if (product == null)
            {
                //redirect
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
