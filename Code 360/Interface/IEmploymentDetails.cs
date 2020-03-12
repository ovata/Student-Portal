using Code_360.Models;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface IEmploymentDetails
    {
        EmploymentDetails AddEmpDetails(EmploymentDetails _employmentDetails);
        EmploymentDetails UpdateEmpDetails(EmploymentDetails _employmentDetails);
        IEnumerable<EmploymentDetails> GetEmploymentDetails();

    }
}
