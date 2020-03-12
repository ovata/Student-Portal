using Code_360.Interface;
using Code_360.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_360.Reposotories
{
    public class StudentGuarantorRepository : IStudentGuarantor
    {
        private StudentDbContext dbContext;

        public StudentGuarantorRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public StudentGuarantor AddStdGtr(StudentGuarantor _studentGuarantor)
        {
            dbContext.StudentGuarantors.Add(_studentGuarantor);
            dbContext.SaveChanges();
            return _studentGuarantor;
        }

        public IEnumerable<StudentGuarantor> GetStudentGuarantor(Guid Id)
        {
            return dbContext.StudentGuarantors.Where(g => g.StudentId == Id);
        }

        public IEnumerable<StudentGuarantor> GetStudentGuarantors()
        {
            return dbContext.StudentGuarantors.Include(sg => sg.Guarantor);
        }

        public StudentGuarantor RemoveStsGtr(Guid Id)
        {
            StudentGuarantor studentGuarantor = dbContext.StudentGuarantors.Find(Id);
            if (studentGuarantor != null)
            {
                dbContext.StudentGuarantors.Remove(studentGuarantor);
                dbContext.SaveChanges();
            }
            return studentGuarantor;
        }

        public StudentGuarantor UpdateStdGtr(StudentGuarantor _studentGuarantor)
        {
            var model = dbContext.StudentGuarantors.Attach(_studentGuarantor);
            model.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _studentGuarantor;
        }
    }
}
