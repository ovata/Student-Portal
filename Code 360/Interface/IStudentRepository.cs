using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(Guid Id);
        Student AddStudent(Student _student);
        Student RemoveStudent(Guid Id);
        Student UpdateStudent(Student studentUpdate);
        IEnumerable<Student> GetAllStudent();
        IEnumerable<StudentGuarantor> StudentGuarantors(Guid Id);
    }
}
