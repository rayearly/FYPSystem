using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYPSystem.Models
{
    public class Supervisor
    {
        public int Id { get; set; }

        [Display(Name = "Staff Number")]
        [Required]
        public string StaffNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int FacultyId { get; set; }

        [Required]
        public Faculty Faculty { get; set; }

        public virtual ICollection<SupervisorStudents> Students { get; set; }
    }
}