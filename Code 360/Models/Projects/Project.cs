using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models.Projects
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Required]
        public ProjectStatus ProjectStatus { get; set; }
        public string ProjectUrl { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
