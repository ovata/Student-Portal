using System;
using System.ComponentModel.DataAnnotations;

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
