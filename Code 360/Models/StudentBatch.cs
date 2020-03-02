using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class StudentBatch
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid BatchId { get; set; }
        public Batch.Batch Batch { get; set; }
    }
}
