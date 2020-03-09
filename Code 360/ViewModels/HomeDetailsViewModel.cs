using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Student Student { get; set; }
        public List<Student> GetStudents { get; set; }
        public string PageTitle { get; set; }
    }
}
