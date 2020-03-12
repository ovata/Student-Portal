using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Reposotories
{
    public class ProgrammeCourseRepository : IProgrammeCourse
    {
        private StudentDbContext dbContext;

        public ProgrammeCourseRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ProgrammeCourse AddProgrammeCourse(ProgrammeCourse _programmeCourse)
        {
            dbContext.ProgrammeCourses.Add(_programmeCourse);
            dbContext.SaveChanges();
            return _programmeCourse;
        }

        public ProgrammeCourse GetProgrammeCourse(Guid Id)
        {
            return dbContext.ProgrammeCourses.Find(Id);
        }

        public IEnumerable<ProgrammeCourse> GetProgrammeCourses()
        {
            return dbContext.ProgrammeCourses;
        }

        public ProgrammeCourse RemoveProgrammeCourse(Guid Id)
        {
            ProgrammeCourse programmeCourse = dbContext.ProgrammeCourses.Find(Id);
            if (programmeCourse != null)
            {
                dbContext.ProgrammeCourses.Remove(programmeCourse);
                dbContext.SaveChanges();
            }
            return programmeCourse;
        }

        public ProgrammeCourse UpdateProgrammeCourse(ProgrammeCourse _programmeCourse)
        {
            var progCourse = dbContext.ProgrammeCourses.Attach(_programmeCourse);
            progCourse.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _programmeCourse;
        }
    }
}
