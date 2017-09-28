using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Management;
using FYPSystem.Models;

namespace FYPSystem.ViewModel
{
    public class StudentRegistrationViewModel
    {
        public Student Student { get; set; }

        [Required]
        public IEnumerable<Course> Courses { get; set; }

        [Required]
        public IEnumerable<Semester> Semesters { get; set; }

        [Required]
        public IEnumerable<Faculty> Faculties { get; set; }

        public IEnumerable<Supervisor> Supervisors { get; set; }

        public int SupervisorId { get; set; }

        public IEnumerable<SupervisorStudents> SupervisorStudentses { get; set; }
    }
}