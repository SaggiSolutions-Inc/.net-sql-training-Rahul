using Microsoft.AspNetCore.Mvc;
using MvcLabs1.Models;

namespace MvcLabs1.Controllers
{
    public class CoursesController : Controller
    {
        CourseBO context = new CourseBO();

        public IActionResult Index()
        {
            //Data is directly assigned in the controller which is not recommend. 
            //Commenting the below data and adding it to the CourseBO(Business Object)
           /* List<CourseModel> courses = new List<CourseModel>
            {
                new CourseModel { Id = 101, Course = ".NET", Faculty = "Kiran", DurationInDays = 45, Fee = 30000 },
                new CourseModel { Id = 102, Course = "Azure", Faculty = "Harshitha", DurationInDays = 30, Fee = 35000 },
                new CourseModel { Id = 103, Course = "SQL", Faculty = "Ravi", DurationInDays = 25, Fee = 36000 },
                new CourseModel { Id = 104, Course = "Angular", Faculty = "Chandu", DurationInDays = 35, Fee = 40000 },

            };*/
            ViewBag.courses = context.GetAll();
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.course = context.GetByID(id);
            return View();
        }
    }
}
