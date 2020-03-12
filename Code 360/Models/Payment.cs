using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code_360.Models
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Total Amount")]
        public double TotalAmount { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public IList<PaymentDetails> PaymentDetails { get; set; }
    }
}
