using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class StudentGuarantor
    {
        public Guid Id { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid GuarantorId { get; set; }
        public Guarantor.Guarantor Guarantor { get; set; }
    }
}
