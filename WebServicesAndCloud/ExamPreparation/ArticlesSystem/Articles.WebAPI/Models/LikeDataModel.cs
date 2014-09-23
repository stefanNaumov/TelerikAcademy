using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Articles.WebAPI.Models
{
    public class LikeDataModel
    {
        public static Expression<Func<Like, LikeDataModel>> FromLike
        {
            get
            {
                return l => new LikeDataModel
                {
                    Id = l.Id,
                    UserId = l.UserId,
                    ArticleId = l.ArticleId
                };
            }
        }
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ArticleId { get; set; }
    }
}