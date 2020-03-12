using System;
using System.Collections.Generic;

namespace Code_360.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(Guid Id);
        Student AddStudent(Student _student);
        Student RemoveStudent(Guid Id);
        Student UpdateStudent(Student studentUpdate);
        IEnumerable<Student> GetAllStudent();

        List<StudentGuarantor> GetSG(Guid id);
    }
}
