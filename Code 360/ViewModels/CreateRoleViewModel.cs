using System.ComponentModel.DataAnnotations;

namespace Code_360.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
