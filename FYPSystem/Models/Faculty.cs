using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYPSystem.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        [Display(Name = "Faculty")]
        [Required]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}