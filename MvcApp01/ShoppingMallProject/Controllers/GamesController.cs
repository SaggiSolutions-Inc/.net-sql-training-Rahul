using Microsoft.AspNetCore.Mvc;

namespace ShoppingMallProject.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tickets()
        {
            return View();
        }
        public IActionResult Games()
        {
            return View();
        }
        public IActionResult Payments()
        {
            return View();
        }
    }
}
