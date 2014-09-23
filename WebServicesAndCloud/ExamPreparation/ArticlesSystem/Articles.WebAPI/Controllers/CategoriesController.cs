using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Articles.Data;
using Articles.WebAPI.Models;

namespace Articles.WebAPI.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(IArticlesData data)
            :base(data)
        {

        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var categories = this.articlesData.Categories.All();

            return Ok(categories);
        }

        public IHttpActionResult GetById(int id)
        {
            var category = this.articlesData.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            var articleModels = category.Articles.AsQueryable().Select(ArticleDataModel.FromArticle);

            return Ok(articleModels);
        }
    }
}