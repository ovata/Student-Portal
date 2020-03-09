using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class PaymentDetails
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name ="Amount Paid")]
        public double AmountPaid { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
