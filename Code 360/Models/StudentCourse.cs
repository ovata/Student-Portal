using System;
using System.ComponentModel.DataAnnotations;

namespace Code_360.Models
{
    public class StudentCourse
    {
        [Key]
        public Guid Id { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid CourseId { get; set; }
        public Course.Course Course { get; set; }
    }
}
