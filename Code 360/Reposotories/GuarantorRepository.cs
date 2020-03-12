using Code_360.Models;
using Code_360.Models.Guarantor;
using Code_360.Models.Interface;
using System;
using System.Collections.Generic;

namespace Code_360.Reposotories
{
    public class GuarantorRepository : IGuarantor
    {
        private StudentDbContext _studentDbContext;

        public GuarantorRepository(StudentDbContext studentDbContext)
        {
            this._studentDbContext = studentDbContext;
        }

        public Guarantor AddGuarantor(Guarantor _guarantor)
        {
            _studentDbContext.Guarantors.Add(_guarantor);
            _studentDbContext.SaveChanges();
            return _guarantor;
        }

        public Guarantor GetGuarantor(Guid Id)
        {
            return _studentDbContext.Guarantors.Find(Id);
        }

        public IEnumerable<Guarantor> GetGuarantors()
        {
            return _studentDbContext.Guarantors;
        }

        public Guarantor UpdateGuarantor(Guarantor updateguarantor)
        {
            var guarantor = _studentDbContext.Guarantors.Attach(updateguarantor);
            guarantor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _studentDbContext.SaveChanges();
            return updateguarantor;
        }
    }
}
