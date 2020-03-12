using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code_360.Models.Programs
{
    public class Programme
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Cost { get; set; }

        public IList<Batch.Batch> Batches { get; set; }
        public IList<ProgrammeCourse> ProgrammeCourses { get; set; }

    }
}
