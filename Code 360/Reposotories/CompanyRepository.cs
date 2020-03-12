using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Reposotories
{
    public class CompanyRepository : ICompany
    {
        private StudentDbContext dbContext;

        public CompanyRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Company AddCompany(Company _company)
        {
            dbContext.Companies.Add(_company);
            dbContext.SaveChanges();
            return _company;
        }

        public IEnumerable<Company> GetCompanies()
        {
            return dbContext.Companies;
        }

        public Company GetCompany(Guid Id)
        {
            return dbContext.Companies.Find(Id);
        }

        public Company UpdateCompany(Company _companyUpdate)
        {
            var company = dbContext.Companies.Attach(_companyUpdate);
            company.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _companyUpdate;
        }
    }
}
