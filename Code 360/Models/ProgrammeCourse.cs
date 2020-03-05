using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class ProgrammeCourse
    {
        [Key]
        public Guid ProgrammeId { get; set; }
        public Programs.Programme Programme { get; set; }

        public Guid CourseId { get; set; }
        public Course.Course Course { get; set; }
    }
}
