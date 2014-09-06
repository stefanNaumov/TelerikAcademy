using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Atm.Models
{
    public class CardAccount
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public string cardNumber { get; set; }

        [MaxLength(4)]
        public string cardPin { get; set; }

        public decimal Balance { get; set; }
    }
}
