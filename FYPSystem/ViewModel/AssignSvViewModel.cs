using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FYPSystem.Models;

namespace FYPSystem.ViewModel
{
    public class AssignSvViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<SupervisorStudents> SupervisorStudentses { get; set; }
        public IEnumerable<Supervisor> Supervisors { get; set; }
    }
}