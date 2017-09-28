using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using FYPSystem.Models;
using FYPSystem.ViewModel;

namespace FYPSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Students - Only viewable by MANAGERS
        public ActionResult Index()
        {
            var students = _context.Students.Include(s => s.Supervisors).ToList();
            return View(students);
        }

        // CREATE: Redirect to New Student Form (Registration)
        public ViewResult New()
        {
            var student = new Student();
            var courses = _context.Courses.ToList();
            var faculties = _context.Faculties.ToList();
            var semesters = _context.Semesters.ToList();
            var mainsupervisors = _context.Supervisors.ToList();
            var cosupervisors = _context.Supervisors.ToList();
            var supervisorstudents = _context.StudentSupervisors.ToList();

            var viewModel = new StudentRegistrationViewModel
            {
                Student = student,
                Courses = courses,
                Faculties = faculties,
                Semesters = semesters,
                Supervisors = mainsupervisors,
                SupervisorStudentses = supervisorstudents
            };

            return View("StudentRegistrationForm", viewModel);
        }

        // UPDATE: Redirect to Student Form based on given ID
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: New or Modification on Student Information
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Student student)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new StudentRegistrationViewModel
                {
                    Student = student,
                    Courses = _context.Courses.ToList(),
                    Faculties = _context.Faculties.ToList(),
                    Semesters = _context.Semesters.ToList(),
                    Supervisors = _context.Supervisors.ToList(),
                    SupervisorStudentses = _context.StudentSupervisors.ToList()
                };

                return View("StudentRegistrationForm", viewModel);
            }

            if (student.Id == 0)
            {
                _context.Students.Add(student);
            }
            else
            {
                
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Students");
        }
    }
}