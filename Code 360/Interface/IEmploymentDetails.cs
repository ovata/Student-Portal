using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Interface
{
    public interface IEmploymentDetails
    {
        EmploymentDetails AddEmpDetails(EmploymentDetails _employmentDetails);
        EmploymentDetails UpdateEmpDetails(EmploymentDetails _employmentDetails);
        IEnumerable<EmploymentDetails> GetEmploymentDetails();

    }
}
