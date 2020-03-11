using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Reposotories
{
    public class PaymentRepository : IPayment
    {
        private StudentDbContext dbContext;

        public PaymentRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Payment AddPayment(Payment _payment)
        {
            dbContext.Payments.Add(_payment);
            dbContext.SaveChanges();
            return _payment;
        }

        public Payment GetPayment(Guid Id)
        {
            return dbContext.Payments.Find(Id);
        }

        public IEnumerable<Payment> GetPayments()
        {
            return dbContext.Payments;
        }

        public Payment RemovePayment(Guid Id)
        {
            Payment payment = dbContext.Payments.Find(Id);
            if (payment != null)
            {
                dbContext.Payments.Remove(payment);
                dbContext.SaveChanges();
            }
            return payment;
        }

        public Payment UpdatePayment(Payment _payment)
        {
            var payment = dbContext.Payments.Attach(_payment);
            payment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _payment;
        }
    }
}
