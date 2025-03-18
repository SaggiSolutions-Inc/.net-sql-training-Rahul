using Microsoft.AspNetCore.Mvc;

namespace RazorDemo.Controllers
{
    public class Demo1Controller : Controller
    {
        //GET: Home
        public IActionResult Index()
        {
            TempData["operations"] = new List<string> { "Create", "Retrive", "Update", "Delete" };

            ViewData["name"] = "Rahul";
            ViewBag.city = "Hyderabad";
            ViewBag.technologies = new string[] { ".NET", "MEAN", "MERN", "AZURE" };
            return View();
        }
        [HttpPost]
        public ActionResult Index(string b1)
        {
            ViewBag.msg = b1;
            return View();
        }
        public IActionResult Ex01()
        {
            string[] students = new string[] { "Nirmala", "Sruthi", "Priya", "Mani", "Anitesh", "Rajesh" };
            ViewBag.students = students;
            return View();
        }

    }
}
