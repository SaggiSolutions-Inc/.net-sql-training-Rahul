using Microsoft.AspNetCore.Mvc;

namespace ShoppingMallProject.Controllers
{
    public class FoodCourtsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Seating()
        {
            return View();
        }
        public IActionResult Cleaning()
        {
            return View();
        }
        public IActionResult Billing()
        {
            return View();
        }
    }
}
