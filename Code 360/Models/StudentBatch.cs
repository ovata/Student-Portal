using System;
using System.ComponentModel.DataAnnotations;

namespace Code_360.Models
{
    public class StudentBatch
    {
        [Key]
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid BatchId { get; set; }
        public Batch.Batch Batch { get; set; }
    }
}
