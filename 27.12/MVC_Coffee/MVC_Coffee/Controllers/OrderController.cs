using Microsoft.AspNetCore.Mvc;

namespace MVC_Coffee.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
