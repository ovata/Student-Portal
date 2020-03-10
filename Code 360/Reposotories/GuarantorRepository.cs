using Code_360.Models;
using Code_360.Models.Guarantor;
using Code_360.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Reposotories
{
    public class GuarantorRepository : IGuarantor
    {
        private StudentDbContext studentDbContext;

        public GuarantorRepository(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }

        public Guarantor AddGuarantor(Guarantor _guarantor)
        {
            studentDbContext.Guarantors.Add(_guarantor);
            studentDbContext.SaveChanges();
            return _guarantor;
        }

        public Guarantor GetGuarantor(Guid Id)
        {
            return studentDbContext.Guarantors.Find(Id);
        }

        public IEnumerable<Guarantor> GetGuarantors()
        {
            return studentDbContext.Guarantors;
        }

        public Guarantor UpdateGuarantor(Guarantor updateguarantor)
        {
            var guarantor = studentDbContext.Guarantors.Attach(updateguarantor);
            guarantor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            studentDbContext.SaveChanges();
            return updateguarantor;
        }
    }
}
