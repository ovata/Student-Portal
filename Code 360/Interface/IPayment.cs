using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface IPayment
    {
        Payment AddPayment(Payment _payment);
        Payment RemovePayment(Guid Id);
        Payment UpdatePayment(Payment _payment);
        Payment GetPayment(Guid Id);
        IEnumerable<Payment> GetPayments();
    }
}
