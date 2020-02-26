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
        public Gender? Gender { get; set; }
        [Required]
        [Display(Name ="D.O.B")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        [Display(Name ="Phone Number")]
        public string Phone { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        [Display(Name ="Marital Status")]
        public MaritalStatus? MaritalStatus { get; set; }
        [Required]
        [Display(Name ="Addmission Type")]
        public AddmissionType? AddmissionType { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string NextOfKinName { get; set; }
        [Required]
        [Display(Name ="Email")]
        [EmailAddress]
        public string NextOfKinEmail { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Phone Number")]
        public string NextOfKinPhone { get; set; }
        [Display(Name ="Document")]
        public string NextOfKinDocumentUrl { get; set; }
        [Required]
        public long BVN { get; set; }
    }
}
