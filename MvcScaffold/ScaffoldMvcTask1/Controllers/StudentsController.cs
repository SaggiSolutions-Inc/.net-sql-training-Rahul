using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScaffoldMvcTask1.Models;

namespace ScaffoldMvcTask1.Controllers
{
    public class StudentsController : Controller
    {
        static StudentBo context = new StudentBo();
        // GET: StudentsController
        public ActionResult Index()
        {
            return View(context.GetAll());
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.GetById(id));
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentModel s)
        {
            try
            {
                context.Add(s);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.GetById(id));
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentModel s)
        {
            try
            {
                context.EditById(s,id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.GetById(id));
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, StudentModel s)
        {
            try
            {
                context.DeleteById(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
