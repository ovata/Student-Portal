using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Reposotories
{
    public class SalaryRepository : ISalary
    {
        private StudentDbContext dbContext;

        public SalaryRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Salary AddSalary(Salary _salary)
        {
            dbContext.Salaries.Add(_salary);
            dbContext.SaveChanges();
            return _salary;
        }

        public IEnumerable<Salary> GetSalaries()
        {
            return dbContext.Salaries;
        }

        public Salary GetSalary(Guid Id)
        {
            return dbContext.Salaries.Find(Id);
        }

        public Salary UpdateSalary(Salary _salary)
        {
            var salary = dbContext.Salaries.Attach(_salary);
            salary.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _salary;
        }
    }
}
