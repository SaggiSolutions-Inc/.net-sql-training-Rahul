using Microsoft.AspNetCore.Mvc;

namespace BankingProject.Controllers
{
    public class SavingsAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewAccount()
        {
            return View();
        }
        public IActionResult LoginAccount()
        {
            return View();
        }
        public IActionResult CloseAccount()
        {
            return View();
        }
    }
}
