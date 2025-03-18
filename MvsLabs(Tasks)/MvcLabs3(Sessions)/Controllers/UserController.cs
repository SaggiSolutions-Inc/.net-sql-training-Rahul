using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MvcLabs3_Sessions_.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String uname,string pwd)
        {
            if (uname == "rahul" && pwd == "rahul")
            {
                //Session to be created after successful login
                HttpContext.Session.SetString("uname", uname);
                return RedirectToAction("dashboard");
            }


            ViewBag.msg = "Invalid Username or Password";
            ViewBag.color = "RED";
            return View();
        }
       
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("uname")!= null)
            {
                var uname = HttpContext.Session.GetString("uname");
                ViewBag.msg = $"Hello {uname},Welcome to dashboard";
                ViewBag.color = "GREEN";
            }
            else
            {
                ViewBag.msg = "Landed on this page using technique..";
                ViewBag.color = "RED";
            }
            return View();
        }
        public IActionResult Confidential()
        {
            if (HttpContext.Session.GetString("uname") != null)
            {
                var uname = HttpContext.Session.GetString("uname");
                ViewBag.msg = $"Hello {uname},Welcome to Confidential page";
                ViewBag.color = "GREEN";
            }
            else
            {
                ViewBag.msg = "Landed on this page using technique..";
                ViewBag.color = "RED";
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("uname") != null)
            {
                var uname = HttpContext.Session.GetString("uname");
                ViewBag.msg = $"Hello {uname}, You have successfully logged out...";
                ViewBag.color = "BLACK";
                HttpContext.Session.Clear();
            }
            else
            {
                ViewBag.msg = "Landed on this page using technique..";
                ViewBag.color = "RED";
            }
            return View();
        }

    }
}
