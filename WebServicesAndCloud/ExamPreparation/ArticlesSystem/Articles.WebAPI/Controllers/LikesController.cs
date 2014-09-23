using Articles.Data;
using Articles.Models;
using Articles.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace Articles.WebAPI.Controllers
{
    public class LikesController : BaseController
    {
        public LikesController(IArticlesData data)
            :base(data)
        {

        }

        [HttpPost]
        public IHttpActionResult Create(int id)
        {
            var article = this.articlesData.Articles.Find(id);

            if (article == null)
            {
                return NotFound();
            }
            var userId = this.User.Identity.GetUserId();

            var like = new Like()
            {
                UserId = userId
            };
            var articleModel = new ArticleDataModel()
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,
                DateCreated = article.DateCreated,
                Likes = article.Likes
            };
            articleModel.Likes.Add(like);

            article.Likes.Add(like);
            this.articlesData.SaveChanges();

            return Ok(articleModel);
        }
    }
}