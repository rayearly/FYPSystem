using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace FYPSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Matric Number")]
        [Required]
        public string MatricNo { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Title")]
        public string ProjectTitle { get; set; }

        public string Abstract { get; set; }

        [Display(Name = "Course Code")]
        public int CourseId { get; set; }

        [Display(Name = "Semester")]
        public int SemesterId { get; set; }

        [Display(Name = "Faculty")]
        public int FacultyId { get; set; }

        public Course Course { get; set; }

        public Faculty Faculty { get; set; }

        public Semester Semester { get; set; }

        public virtual IList<SupervisorStudents> Supervisors { get; set; }
    }
}