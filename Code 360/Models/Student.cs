using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Gender? Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public MaritalStatus? MaritalStatus { get; set; }
        [Required]
        public AddmissionType? AddmissionType { get; set; }
        [Required]
        public string NextOfKinName { get; set; }
        [Required]
        [EmailAddress]
        public string NextOfKinEmail { get; set; }
        [Required]
        public string NextOfKinPhone { get; set; }
        public string NextOfKinDocumentUrl { get; set; }
        [Required]
        public long BVN { get; set; }


        public IList<StudentBatch> StudentBatches { get; set; }
        public IList<Project> Projects { get; set; }
        public IList<Payment> Payments { get; set; }
        public IList<EmploymentDetails> EmploymentDetails { get; set; }
        public IList<StudentGuarantor> StudentGuarantors { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}
