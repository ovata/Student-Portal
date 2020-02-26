using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models.Programs
{
    public class Programs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
