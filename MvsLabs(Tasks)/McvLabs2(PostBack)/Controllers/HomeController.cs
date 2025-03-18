using System.Diagnostics;
using McvLabs2_PostBack_.Models;
using Microsoft.AspNetCore.Mvc;

namespace McvLabs2_PostBack_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.msg = "Hello,Welcome!";
            return View();
        }

        [HttpPost]
            public IActionResult Index(string b1)
            {
            ViewBag.msg = "Hi,Welcome back";
            return View();
            }

        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            if (uname == "rahul" && pwd == "rahul")
                return RedirectToAction("dashboard");
            else
                ViewBag.msg = "Invalid usernamer or Password.";
            return View();
        }
        public IActionResult Dashboard()
        {
            ViewBag.msg = "Hi, you have successfully logged in ";
            return View();
        }
        public IActionResult Logout()
        {
            ViewBag.msg = "You have successfully logged out";
            return View();
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
