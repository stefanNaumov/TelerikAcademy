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
    public class CommentsController : BaseController
    {
        public CommentsController(IArticlesData data)
            :base(data)
        {

        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var article = this.articlesData.Articles.Find(id);

            if (article == null)
            {
                return NotFound();
            }

            var comments = article.Comments.AsQueryable().Take(10).Select(CommentDataModel.FromComment);

            return Ok(comments);
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(int id, CommentDataModel dataModel)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }
            var userId = this.User.Identity.GetUserId();
            var newComment = new Comment()
            {
                UserId = userId,
                Content = dataModel.Content,
                DateCreated = DateTime.Now,
                ArticleId = id
            };

            this.articlesData.Articles.Find(id).Comments.Add(newComment);
            this.articlesData.SaveChanges();

            dataModel.Id = newComment.Id;
            dataModel.Content = newComment.Content;
            dataModel.DateCreated = newComment.DateCreated;

            return Ok(dataModel);
        }
    }
}