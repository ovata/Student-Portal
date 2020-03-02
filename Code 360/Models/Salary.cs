using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class Salary
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public DateTime ExpectedPayDay { get; set; }

        public Guid EmploymentId { get; set; }
        public EmploymentDetails EmploymentDetails { get; set; }

    }
}
