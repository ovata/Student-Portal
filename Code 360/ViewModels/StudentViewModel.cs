using Code_360.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.ViewModels
{
    public class StudentViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public gender? Gender { get; set; }
        [Display(Name = "DOB")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Photo")]
        public IFormFile Photo { get; set; }
        [Required]
        public maritalStatus? MaritalStatus { get; set; }
        [Required]
        [Display(Name = "Addmission Type")]
        public addmissionType? AddmissionType { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string NextOfKinName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string NextOfKinEmail { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string NextOfKinPhone { get; set; }
        public string NextOfKinDocumentUrl { get; set; }
        [Required]
        public long BVN { get; set; }
    }
}
