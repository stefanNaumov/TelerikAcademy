using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Atm.Models
{
    public class TransactionHistory
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string CardNumberId { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Ammount { get; set; }
    }
}
