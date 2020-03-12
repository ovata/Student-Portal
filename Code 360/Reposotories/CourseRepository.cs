using Code_360.Interface;
using Code_360.Models;
using Code_360.Models.Course;
using System;
using System.Collections.Generic;

namespace Code_360.Reposotories
{
    public class CourseRepository : ICourse
    {
        private StudentDbContext studentDb;

        public CourseRepository(StudentDbContext studentDb)
        {
            this.studentDb = studentDb;
        }

        public Course AddCourse(Course _course)
        {
            studentDb.Courses.Add(_course);
            studentDb.SaveChanges();
            return _course;
        }

        public Course GetCourse(Guid Id)
        {
            return studentDb.Courses.Find(Id);
        }

        public IEnumerable<Course> GetCourses()
        {
            return studentDb.Courses;
        }

        public Course RemoveCourse(Guid Id)
        {
            Course course = studentDb.Courses.Find(Id);
            {
                if (course != null)
                {
                    studentDb.Courses.Remove(course);
                    studentDb.SaveChanges();
                }
                return course;
            }
        }

        public Course UpdateCourse(Course _courseUpdate)
        {
            var course = studentDb.Courses.Attach(_courseUpdate);
            course.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            studentDb.SaveChanges();
            return _courseUpdate;
        }
    }
}
