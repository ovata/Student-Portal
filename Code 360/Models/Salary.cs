using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class Salary
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        [Display(Name ="Salary")]
        public double SalaryAmount { get; set; }
        [Required]
        [Display(Name ="Pay Day")]
        [DataType(DataType.Date)]
        public DateTime ExpectedPayDay { get; set; }

        public Guid EmploymentId { get; set; }
        public EmploymentDetails EmploymentDetails { get; set; }

    }
}
