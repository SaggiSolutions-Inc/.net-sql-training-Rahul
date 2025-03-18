using Microsoft.AspNetCore.Mvc;

namespace McvLabs2_PostBack_.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int a, int b,string b1)
        {
            switch (b1)
            {
                case "add":
                    ViewBag.msg = $"Add of {a} and {b} is {a + b}";
                    break;
                case "sub":
                    ViewBag.msg = $"Sub of {a} and {b} is {a - b}";
                    break;
                case "mult":
                    ViewBag.msg = $"Mult of {a} and {b} is {a * b}";
                    break;
                case "div":
                    ViewBag.msg = $"Div of {a} and {b} is {a / b}";
                    break;

            }
            return View();
        }
    }
}
