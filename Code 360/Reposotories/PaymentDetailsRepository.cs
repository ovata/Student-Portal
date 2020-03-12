using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Reposotories
{
    public class PaymentDetailsRepository : IPaymentDetails
    {
        private StudentDbContext dbContext;

        public PaymentDetailsRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public PaymentDetails AddPaymentDetails(PaymentDetails _paymentDetails)
        {
            dbContext.PaymentDetails.Add(_paymentDetails);
            dbContext.SaveChanges();
            return _paymentDetails;
        }

        public PaymentDetails GetPayment(Guid Id)
        {
            return dbContext.PaymentDetails.Find(Id);
        }

        public IEnumerable<PaymentDetails> GetPaymentDetails()
        {
            return dbContext.PaymentDetails;
        }

        public PaymentDetails UpdatePaymentDetails(PaymentDetails _paymentDetails)
        {
            var payment = dbContext.PaymentDetails.Attach(_paymentDetails);
            payment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _paymentDetails;
        }
    }
}
