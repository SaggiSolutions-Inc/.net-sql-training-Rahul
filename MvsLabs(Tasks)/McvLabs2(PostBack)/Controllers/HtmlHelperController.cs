using Microsoft.AspNetCore.Mvc;

namespace McvLabs2_PostBack_.Controllers
{
    public class HtmlHelperController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.msg = "Hello,Welcome!";
            return View();
        }
        [HttpPost]        
        
        public IActionResult Index(string t1)
        {
            ViewBag.msg = "Hi "+ t1;
            return View();
        }
        [HttpGet]
        public IActionResult Ex01()
        {
            ViewBag.msg = "Welcome to Ex01";
            return View();
        }
        [HttpPost]
        public IActionResult Ex01(string t1,string b2)
        {
            switch(b2)
            {
                case "hello":
                    ViewBag.msg = $"Hello {t1}";
                    break;
                case "len":
                    ViewBag.msg = $"Length of {t1} is {t1.Length}";
                    break;
                case "upper":
                    ViewBag.msg = t1.ToUpper();
                    break;
                case "lower":
                    ViewBag.msg = t1.ToLower();
                    break;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Ex02()
        {
            ViewBag.msg = "Welcome to Ex02";
            return View();
        }
        [HttpPost]

        public IActionResult Ex02(string b1)
        {
            ViewBag.msg = "Welcome to Ex02";
            return View();
        }
    } 
}
