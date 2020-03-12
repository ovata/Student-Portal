using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Reposotories
{
    public class StudentBatchRepository : IStudentBatch
    {
        private StudentDbContext dbContext;

        public StudentBatchRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public StudentBatch AddStdBatch(StudentBatch _studentBatch)
        {
            dbContext.StudentBatches.Add(_studentBatch);
            dbContext.SaveChanges();
            return _studentBatch;
        }

        public StudentBatch GetStdBatch(Guid Id)
        {
            return dbContext.StudentBatches.Find(Id);
        }

        public IEnumerable<StudentBatch> GetStudentBatches()
        {
            return dbContext.StudentBatches;
        }

        public StudentBatch RemoveStdBatch(Guid Id)
        {
            StudentBatch studentBatch = dbContext.StudentBatches.Find(Id);
            if (studentBatch != null)
            {
                dbContext.StudentBatches.Remove(studentBatch);
                dbContext.SaveChanges();
            }
            return studentBatch;
        }

        public StudentBatch UpdateStdBatch(StudentBatch _studentBatch)
        {
            var stdBatch = dbContext.StudentBatches.Attach(_studentBatch);
            stdBatch.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _studentBatch;
        }
    }
}
