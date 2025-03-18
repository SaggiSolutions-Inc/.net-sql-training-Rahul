using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScaffoldMvcTask1.Models;

namespace ScaffoldMvcTask1.Controllers
{
    public class CoursesController : Controller
    {
        static CourseBO context = new CourseBO();
        // GET: CoursesController
        public ActionResult Index()
        {
            return View(context.GetAll());
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.GetById(id));
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseModel c)
        {
            try
            {
                context.Add(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.GetById(id));
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CourseModel c)
        {
            try
            {
                context.EditById(c,id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.GetById(id));
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CourseModel c)
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
