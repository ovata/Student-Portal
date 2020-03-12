using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Reposotories
{
    public class StudentCourseRepository : IStudentCourse
    {
        private StudentDbContext dbContext;

        public StudentCourseRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Models.StudentCourse AddStdCourse(Models.StudentCourse _studentCourse)
        {
            dbContext.StudentCourses.Add(_studentCourse);
            dbContext.SaveChanges();
            return _studentCourse;
        }

        public Models.StudentCourse GetStudentCourse(Guid Id)
        {
            return dbContext.StudentCourses.Find(Id);
        }

        public IEnumerable<Models.StudentCourse> GetStudentCourses()
        {
            return dbContext.StudentCourses;
        }

        public Models.StudentCourse RemoveStdCourse(Guid Id)
        {
            Models.StudentCourse studentCourse = dbContext.StudentCourses.Find(Id);
            if (studentCourse != null)
            {
                dbContext.StudentCourses.Remove(studentCourse);
                dbContext.SaveChanges();
            }
            return studentCourse;
        }

        public Models.StudentCourse UpdateStdCourse(Models.StudentCourse _studentCourse)
        {
            var stdCourse = dbContext.StudentCourses.Attach(_studentCourse);
            stdCourse.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _studentCourse;
        }
    }
}
