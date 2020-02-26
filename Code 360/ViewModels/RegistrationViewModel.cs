using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and Confirm Password does not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
