using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        public DateTime Date { get; set; }

        public int? AuthorID { get; set; }

        public virtual Book Book { get; set; }

        public string Content { get; set; }

        public virtual Author Author { get; set; }
    }
}
