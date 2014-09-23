using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Articles.WebAPI.Models
{
    public class CommentDataModel
    {
        public static Expression<Func<Comment, CommentDataModel>> FromComment
        {
            get
            {
                return l => new CommentDataModel
                {
                    Id = l.Id,
                    Content = l.Content,
                    DateCreated = l.DateCreated,
                };
            }
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public int ArticleId { get; set; }

        public string UserId { get; set; }
    }
}