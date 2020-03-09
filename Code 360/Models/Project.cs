using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name ="Project Name")]
        public string Name { get; set; }
        [Display(Name ="Projecr Status")]
        public ProjectStatus ProjectStatus { get; set; }
        public string Url { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
