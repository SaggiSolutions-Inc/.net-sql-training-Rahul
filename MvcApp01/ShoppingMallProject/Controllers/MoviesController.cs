using Microsoft.AspNetCore.Mvc;

namespace ShoppingMallProject.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Showtimes()
        {
            return View();
        }

        public IActionResult Booking()
        {
            return View();
        }

        public IActionResult Snacks()
        {
            return View();
        }

        public IActionResult Cleaning()
        {
            return View();
        }
    }
}
