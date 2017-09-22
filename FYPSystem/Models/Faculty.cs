using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYPSystem.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}