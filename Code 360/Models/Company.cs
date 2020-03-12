using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code_360.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public IList<EmploymentDetails> EmploymentDetails { get; set; }

    }
}
