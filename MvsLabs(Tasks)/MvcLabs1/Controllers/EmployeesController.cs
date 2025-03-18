using Microsoft.AspNetCore.Mvc;
using MvcLabs1.Models;

namespace MvcLabs1.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeBO context = new EmployeeBO();

        public IActionResult Index()
        {
          //Data is directly assigned in the controller,which is not recommend. 
          //Commenting the below data and adding it to the EmployeeBO(Business Object)

          /*  ViewBag.employees = new List<EmployeeModel>
            {
                new EmployeeModel{Id = 1,EName="Maikanta Rahul",Job=".NET Devloper",Salary=220000},
                new EmployeeModel{Id=2,EName="Sai Tarun",Job="Data Analyst",Salary=250000},
                new EmployeeModel{Id=3,EName="Jyo",Job="UI Designer",Salary=300000}
            };*/
            
            ViewBag.employees = context.GetAll();
            return View();
        }
        public IActionResult Details(int id)
        {
            EmployeeModel e = context.GetbyID(id);
            ViewBag.e = e;
            return View();
        }


    }
}
