using Microsoft.AspNetCore.Mvc;
using MvcCrudops.Models;

namespace MvcCrudops.Controllers
{
    public class DepartmentController : Controller
    {
        static DepartmentBO context = new DepartmentBO(); // As data is dummy data (coming from collection) should be static when perform operation like (CRUD)
        public IActionResult Index()
        {
            List<DepartmentModel> departments = context.GetAll();
            ViewBag.departments = departments;
            return View();
        }
        // Displays details of a specific department.
        public IActionResult Details(int id)
        {
            DepartmentModel d = context.GetById(id);
            ViewBag.d = d;
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            DepartmentModel d = context.GetById(id);
            ViewBag.d = d;
            return View();
        }
        // Deletes the specified department.
        [HttpPost]
        public IActionResult Delete(int id, DepartmentModel d)
        {
            context.DeleteById(d.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        // Creates a new department.
        [HttpPost]
        public IActionResult Create(int id, string dname, string location)
        {
            DepartmentModel d = new DepartmentModel
            {
                Id = id,
                DName = dname,
                Location = location
            };
            context.Add(d);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.d = context.GetById(id);
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id,string dname,string location)
        {
            DepartmentModel d = new DepartmentModel
            {
                Id = id,
                DName = dname,
                Location = location

            };
            context.UpdateById(id, d);
            return RedirectToAction("index");
        }
    }
}
