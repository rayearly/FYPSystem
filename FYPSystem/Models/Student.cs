using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYPSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string MatricNo { get; set; }

        public string Name { get; set; }

        public int CourseId { get; set; }

        public int SemesterId { get; set; }

        public int FacultyId { get; set; }

        public int ProjectId { get; set; }

        public Course Course { get; set; }

        public Faculty Faculty { get; set; }

        public Semester Semester { get; set; }

        public Project Project { get; set; }

        public virtual ICollection<SupervisorStudents> Supervisors { get; set; }
    }
}