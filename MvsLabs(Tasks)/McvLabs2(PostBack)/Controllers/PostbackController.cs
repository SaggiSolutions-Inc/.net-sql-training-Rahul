using Microsoft.AspNetCore.Mvc;

namespace McvLabs2_PostBack_.Controllers
{
    public class PostbackController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "Hello,Welcome to Postback Examples!";
            return View();
        }
        [HttpGet]
        public IActionResult Ex01()
        {
            ViewBag.msg = "Hello,Welcome to Ex01!";
            return View();
        }
        
        [HttpPost]
        public IActionResult Ex01(string b1)
        {
            ViewBag.msg = b1 + " Clicked";
            return View();
        }

        [HttpGet]
        public IActionResult Ex02()
        {
            ViewBag.msg = "Hello,Welcome to Ex02!";
            return View();
        }

        [HttpPost]
        public IActionResult Ex02(string b2)
        {
            ViewBag.msg = b2 + " Clicked";
            return View();
        }

        [HttpGet]
        public IActionResult Ex03()
        {
            ViewBag.msg = "Hello,Welcome to Ex03!";
            return View();
        }

        [HttpPost]
        public IActionResult Ex03(string b2)
        {
            ViewBag.msg = b2 + " Clicked";
            return View();
        }
        [HttpGet]
        public IActionResult Ex04()
        {
            ViewBag.msg = "Hello,Welcome to Ex04!";
            return View();
        }

        [HttpPost]
        public IActionResult Ex04(string b2)
        {
            if (b2 == "date")
                ViewBag.msg = DateTime.Now.ToLongDateString();
            else if (b2=="time")
                ViewBag.msg = DateTime.Now.ToShortTimeString();
          
            return View();
        }
        [HttpGet]
        public IActionResult Ex05()
        {
            ViewBag.msg = "Hello,Welcome to Ex05!";
            return View();
        }

        [HttpPost]
        public IActionResult Ex05(string b2,string gender)
        {
            if(gender == "m")
                ViewBag.msg ="Hello Mr." + b2.ToUpper();
            else if(gender == "f")
                ViewBag.msg = "Hello Ms."+ b2.ToUpper();
            return View();
        }
    }
}
