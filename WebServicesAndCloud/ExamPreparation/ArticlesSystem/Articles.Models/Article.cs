using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Models
{
    public class Article
    {
        public Article()
        {
            this.Comments = new HashSet<Comment>();
            this.Tags = new HashSet<Tag>();
            this.Likes = new HashSet<Like>();
        }
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }


        public virtual ICollection<Like> Likes { get; set; }
        
    }
}
