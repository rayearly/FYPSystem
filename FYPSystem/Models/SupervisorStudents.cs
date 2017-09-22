using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FYPSystem.Models
{
    public class SupervisorStudents
    {
        [Key, Column(Order = 0)]
        public int SupervisorId { get; set; }

        [Key, Column(Order = 1)]
        public int StudentId { get; set; }

        public string TagMainOrCo { get; set; }

        public virtual Supervisor Supervisor { get; set; }

        public virtual Student Student { get; set; }
        
        // go to branch test
    }
}