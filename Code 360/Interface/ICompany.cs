using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Interface
{
    public interface ICompany
    {
        Company AddCompany(Company _company);
        Company GetCompany(Guid Id);
        Company UpdateCompany(Company _companyUpdate);
        IEnumerable<Company> GetCompanies();
    }
}
