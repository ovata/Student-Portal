using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface IStudentCourse
    {
        StudentCourse AddStdCourse(StudentCourse _studentCourse);
        StudentCourse UpdateStdCourse(StudentCourse _studentCourse);
        StudentCourse GetStudentCourse(Guid Id);
        StudentCourse RemoveStdCourse(Guid Id);
        IEnumerable<StudentCourse> GetStudentCourses();

    }
}
