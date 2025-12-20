using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_Controller.Controllers
{
    public class HomeController : Controller
    {
        #region Methods
        ////Index Method
        //public string Index()
        //{
        //    return "Anasayfa";
        //}

        ////About Method
        //public string About()
        //{
        //    return "Hakkımızda";
        //} 
        #endregion

        //Index
        //IActionResult
        public IActionResult Index()
        {
            return View(); //sayfa
        }

        //About
        public IActionResult About()
        {
            return View();
        }

        //Contact
        public IActionResult Contact()
        {
            return View();
        }
    }
}
