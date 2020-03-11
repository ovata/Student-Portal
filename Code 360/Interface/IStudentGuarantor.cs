using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Interface
{
    public interface IStudentGuarantor
    {
        StudentGuarantor AddStdGtr(StudentGuarantor _studentGuarantor);
        StudentGuarantor UpdateStdGtr(StudentGuarantor _studentGuarantor);
        StudentGuarantor GetStudentGuarantor(Guid Id);
        StudentGuarantor RemoveStsGtr(Guid Id);
        IEnumerable<StudentGuarantor> GetStudentGuarantors();
    }
}
