using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface IStudentGuarantor
    {
        StudentGuarantor AddStdGtr(StudentGuarantor _studentGuarantor);
        StudentGuarantor UpdateStdGtr(StudentGuarantor _studentGuarantor);
        IEnumerable<StudentGuarantor> GetStudentGuarantor(Guid Id);
        StudentGuarantor RemoveStsGtr(Guid Id);
        IEnumerable<StudentGuarantor> GetStudentGuarantors();
    }
}
