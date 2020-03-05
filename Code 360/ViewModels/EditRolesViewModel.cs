using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.ViewModels
{
    public class EditRolesViewModel
    {
        public EditRolesViewModel()
        {
            Users = new List<string>();
        }
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Role Name is required")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
