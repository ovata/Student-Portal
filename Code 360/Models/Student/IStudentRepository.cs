using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int Id);
        IEnumerable<Student> GetAllStudent();
        Student AddStudent(Student _student);
        Student RemoveStudent(int Id);
        Student UpdateStudent(Student studentUpdate);
    }
}
