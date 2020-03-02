using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public string Url { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
