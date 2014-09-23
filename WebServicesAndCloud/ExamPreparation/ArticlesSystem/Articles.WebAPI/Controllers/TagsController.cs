using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Articles.Data;
using Articles.WebAPI.Models;

namespace Articles.WebAPI.Controllers
{
    public class TagsController : BaseController
    {
        public TagsController(IArticlesData data)
            :base(data)
        {

        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var tags = this.articlesData.Tags.All();

            return Ok(tags);
        }

        [HttpGet]

        public IHttpActionResult GetById(int id)
        {
            var tag = this.articlesData.Tags.Find(id);
            if (tag == null)
            {
                return NotFound();
            }

            var articles = tag.Articles.AsQueryable().OrderBy(a => a.DateCreated).Select(ArticleDataModel.FromArticle);

            return Ok(articles);
        }
    }
}