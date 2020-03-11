using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public StudentGuarantor GetStudentGuarantor(Guid Id)
        {
            return dbContext.StudentGuarantors.Find(Id);
        }

        public IEnumerable<StudentGuarantor> GetStudentGuarantors()
        {
            return dbContext.StudentGuarantors;
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
