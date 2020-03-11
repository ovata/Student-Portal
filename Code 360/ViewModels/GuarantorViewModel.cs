using Code_360.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.ViewModels
{
    public class GuarantorViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Relationship Relationship { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Nationality { get; set; }
    }
}
