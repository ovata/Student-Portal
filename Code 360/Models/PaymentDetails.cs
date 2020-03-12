using System;
using System.ComponentModel.DataAnnotations;

namespace Code_360.Models
{
    public class PaymentDetails
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Amount Paid")]
        public double AmountPaid { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
