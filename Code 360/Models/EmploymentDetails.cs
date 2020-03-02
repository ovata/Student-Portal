using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class EmploymentDetails
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public IList<Salary> Salaries { get; set; }
    }
}
