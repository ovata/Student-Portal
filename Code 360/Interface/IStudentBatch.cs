using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Interface
{
    public interface IStudentBatch
    {
        StudentBatch AddStdBatch(StudentBatch _studentBatch);
        StudentBatch UpdateStdBatch(StudentBatch _studentBatch);
        StudentBatch GetStdBatch(Guid Id);
        StudentBatch RemoveStdBatch(Guid Id);
        IEnumerable<StudentBatch> GetStudentBatches();
    }
}
