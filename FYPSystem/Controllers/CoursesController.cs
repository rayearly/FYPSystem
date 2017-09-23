using System.Linq;
using System.Web.Mvc;
using FYPSystem.Models;

namespace FYPSystem.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Courses
        public ViewResult Index()
        {
            var courses = _context.Courses.ToList();

            return View(courses);
        }

        // CREATE: New Course
        public ViewResult New()
        {

            return View("CourseForm");
        }

        // EDIT: Course (Id)
        public ActionResult Edit(int id)
        {
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);

            if (course == null)
                return HttpNotFound();

            return View("CourseForm", course);
        }

        // SAVE (Edited & New) Course
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Course course)
        {
            // Push button, if validation failed, redirect back to CourseForm
            if (!ModelState.IsValid)
            {
                var courseValidaton = _context.Courses.SingleOrDefault();

                return View("CourseForm", courseValidaton);
            }

            // New Course
            if (course.Id == 0)
            {
                _context.Courses.Add(course);
            }

            // Editing Course
            else
            {
                var courseInDb = _context.Courses.Single(c => c.Id == course.Id);

                courseInDb.CourseCode = course.CourseCode;
                courseInDb.Name = course.Name;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Courses");
        }
    }
}
