using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Code_360.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(controller: "account", action: "IsEmailAvailable")]
        public string Email { get; set; }
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password does not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
