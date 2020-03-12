using System;

namespace Code_360.Models
{
    public class StudentGuarantor
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid GuarantorId { get; set; }
        public Guarantor.Guarantor Guarantor { get; set; }
    }
}
