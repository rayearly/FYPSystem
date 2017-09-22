using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYPSystem.Models
{
    public class Supervisor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int FacultyId { get; set; }

        public Faculty Faculty { get; set; }

        public virtual ICollection<SupervisorStudents> Students { get; set; }
    }
}