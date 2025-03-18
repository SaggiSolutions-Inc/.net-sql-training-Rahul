using Microsoft.AspNetCore.Mvc;
using MvcLabs1.Models;

namespace MvcLabs1.Controllers
{
    public class PeopleController : Controller
    {
        PersonBO context = new PersonBO();

        public IActionResult Index()
        {
            //Data assigned in the controller is not recommended.
            //Commenting the below data and adding it to the PersonBO(Business Object)

           /* List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { Id = 101, PName = "Rahul", Gender = "Male", Age = 26 });
            people.Add(new PersonModel { Id =102, PName = "Tarun", Gender = "Male", Age = 28});
            people.Add(new PersonModel { Id = 103, PName = "Jyo", Gender = "Female", Age = 30 });*/
            
            List<PersonModel> people = context.GetAll();
            ViewBag.people = people;
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.people = context.GetById(id);
            return View();

        }
    }
}
