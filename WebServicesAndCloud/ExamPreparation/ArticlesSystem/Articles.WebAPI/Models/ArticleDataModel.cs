using Articles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Articles.WebAPI.Models
{
    public class ArticleDataModel
    {
        //TODO add tags to model
        public static Expression<Func<Article, ArticleDataModel>> FromArticle
        {
            get
            {
                return a => new ArticleDataModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    DateCreated = DateTime.Now,
                    Category = a.Category.Name,
                    Tags = a.Tags.Select(t => t.Name),
                    Comments = a.Comments
                };
            }
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserName { get; set; }

        public DateTime DateCreated { get; set; }

        [Required]
        public string Category { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public  ICollection<Comment> Comments { get; set; }


        public  ICollection<Like> Likes { get; set; }
    }
}