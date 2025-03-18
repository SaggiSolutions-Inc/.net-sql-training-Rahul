using Microsoft.AspNetCore.Mvc;

namespace BankingProject.Controllers
{
    public class LoansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
