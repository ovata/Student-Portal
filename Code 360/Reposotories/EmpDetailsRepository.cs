using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Reposotories
{
    public class EmpDetailsRepository : IEmploymentDetails
    {
        private StudentDbContext dbContext;

        public EmpDetailsRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public EmploymentDetails AddEmpDetails(EmploymentDetails _employmentDetails)
        {
            dbContext.EmploymentDetails.Add(_employmentDetails);
            dbContext.SaveChanges();
            return _employmentDetails;
        }

        public IEnumerable<EmploymentDetails> GetEmploymentDetails()
        {
            return dbContext.EmploymentDetails;
        }

        public EmploymentDetails UpdateEmpDetails(EmploymentDetails _employmentDetails)
        {
            var EmpDetails = dbContext.EmploymentDetails.Attach(_employmentDetails);
            EmpDetails.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _employmentDetails;
        }
    }
}
