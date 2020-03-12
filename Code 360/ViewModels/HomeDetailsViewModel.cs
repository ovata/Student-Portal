using Code_360.Models;
using System.Collections.Generic;

namespace Code_360.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Student Student { get; set; }
        public List<Student> GetStudents { get; set; }
        public string PageTitle { get; set; }
    }
}
