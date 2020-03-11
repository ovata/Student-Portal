using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Interface
{
    public interface IPaymentDetails
    {
        PaymentDetails AddPaymentDetails(PaymentDetails _paymentDetails);
        PaymentDetails GetPayment(Guid Id);
        PaymentDetails UpdatePaymentDetails(PaymentDetails _paymentDetails);
        IEnumerable<PaymentDetails> GetPaymentDetails();
    }
}
