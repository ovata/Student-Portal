using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class PaymentDetails
    {
        public Guid Id { get; set; }
        public double AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }

        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
