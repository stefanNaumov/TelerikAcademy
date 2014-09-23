using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Articles.WebAPI.Models
{
    public class ArticleDataModelById
    {
        public ArticleDataModelById(Article article)
        {
            this.Id = article.Id;
            this.Title = article.Title;
            this.Content = article.Content;
            this.DateCreated = article.DateCreated;
            this.CategoryId = article.CategoryId;
            this.UserId = article.UserId;
            this.Tags = article.Tags.Select(t => t.Name).ToArray();
            this.Comments = article.Comments.AsQueryable().Select(CommentDataModel.FromComment).ToArray();
            this.Likes = article.Likes.AsQueryable().Select(LikeDataModel.FromLike).ToArray();

        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        public string UserId { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public ICollection<CommentDataModel> Comments { get; set; }


        public ICollection<LikeDataModel> Likes { get; set; }
    }
}