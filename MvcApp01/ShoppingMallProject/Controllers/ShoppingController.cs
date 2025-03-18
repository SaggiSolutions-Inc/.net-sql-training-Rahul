using Microsoft.AspNetCore.Mvc;

namespace ShoppingMallProject.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Stores()
        {
            return View();
        }

        public IActionResult Offers()
        {
            return View();
        }

        public IActionResult Payments()
        {
            return View();
        }

        public IActionResult CustomerService()
        {
            return View();
        }
    }
}
