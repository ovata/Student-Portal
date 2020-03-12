using Code_360.Models;
using Code_360.Models.Batch;
using Code_360.Models.Course;
using Code_360.Models.Guarantor;
using Code_360.Models.Programs;
using System.Collections.Generic;

namespace Code_360.ViewModels
{
    public class AllModelsViewModel
    {
        public Student Student { get; set; }
        public List<Student> GetStudents { get; set; }

        public Guarantor Guarantor { get; set; }
        public List<Guarantor> AllGuarantors { get; set; }
        public List<StudentGuarantor> GetGuarantors { get; set; }

        public Batch Batch { get; set; }
        public List<Batch> GetBatches { get; set; }

        public Course Course { get; set; }
        public List<Course> GetCourses { get; set; }

        public EmploymentDetails EmploymentDetails { get; set; }
        public List<EmploymentDetails> GetEmploymentDetails { get; set; }

        public Payment Payment { get; set; }
        public List<Payment> GetPayments { get; set; }

        public PaymentDetails PaymentDetails { get; set; }
        public List<PaymentDetails> GetPaymentDetails { get; set; }

        public Programme Programme { get; set; }
        public List<Programme> GetProgrammes { get; set; }

        public ProgrammeCourse ProgrammeCourse { get; set; }
        public List<ProgrammeCourse> GetProgrammeCourses { get; set; }

        public Project Project { get; set; }
        public List<Project> GetProjects { get; set; }

        public Salary Salary { get; set; }
        public List<Salary> GetSalaries { get; set; }

        public StudentBatch StudentBatch { get; set; }
        public List<StudentBatch> GetStudentBatches { get; set; }

        public StudentCourse StudentCourse { get; set; }
        public List<StudentCourse> GetStudentCourses { get; set; }

        public StudentGuarantor StudentGuarantor { get; set; }
        public List<StudentGuarantor> GetStudentGuarantors { get; set; }
        public string PageTitle { get; set; }
    }
}
