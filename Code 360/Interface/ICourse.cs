using Code_360.Models.Course;
using System;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface ICourse
    {
        Course AddCourse(Course _course);
        Course UpdateCourse(Course _courseUpdate);
        Course RemoveCourse(Guid Id);
        Course GetCourse(Guid Id);
        IEnumerable<Course> GetCourses();
    }
}
