using Articles.Data;
using Articles.Models;
using Articles.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.AspNet.Identity;

namespace Articles.WebAPI.Controllers
{
    public class ArticlesController : BaseController
    {
        
        public ArticlesController(IArticlesData data)
            :base(data)
        {

        }

        [HttpGet]
        public IHttpActionResult All() 
        {
            var articles = this.articlesData.Articles.All();

            return Ok(articles);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var article = this.articlesData.Articles.Find(id);
            if (article == null)
            {
                return NotFound();
            }
            var articleModel = new ArticleDataModelById(article);

            return Ok(articleModel);
        }

        [HttpPost]
        public IHttpActionResult Create(ArticleDataModel articleModel)
        {
            var currentUserID = this.User.Identity.GetUserId();

            var category = GetCategory(articleModel);
            var tags = GetTags(articleModel);

            var article = new Article
            {
                UserId = currentUserID,
                DateCreated = DateTime.Now,
                Title = articleModel.Title,
                Content = articleModel.Content,
                CategoryId = category.Id,
                Tags = tags,
            };

            this.articlesData.Articles.Add(article);
            this.articlesData.SaveChanges();

            articleModel.Id = article.Id;
            articleModel.DateCreated = article.DateCreated;
            articleModel.Tags = article.Tags.Select(t => t.Name);

            return Ok(articleModel);
            //var userId = this.User.Identity.GetUserId();
            //var tags = this.GetTags(articleModel);
            //var category = this.GetCategory(articleModel);

            //var article = new Article()
            //{
            //    Id = articleModel.Id,
            //    Title = articleModel.Title,
            //    Content = articleModel.Content,
            //    DateCreated = DateTime.Now,
            //    CategoryId = category.Id,
            //    Tags = tags,
            //    UserId = userId
            //};
            //this.articlesData.Articles.Add(article);
            //this.articlesData.SaveChanges();

            //articleModel.Id = article.Id;
            //articleModel.DateCreated = article.DateCreated;
            //articleModel.Tags = article.Tags.Select(t => t.Name);
            //return Ok(articleModel);
        }

        [HttpGet]
        public IHttpActionResult All(string category)
        {
            return this.All(category, 0);
        }

        [HttpGet]
        public IHttpActionResult All(int page)
        {
            return this.All(null, page);
        }

        [HttpGet]
        public IHttpActionResult All(string category, int page)
        {
            if (articlesData == null)
            {
                var articles = this.articlesData.Articles.All()
                .OrderBy(a => a.DateCreated)
                .Skip(10 * page)
                .Take(10)
                .Select(ArticleDataModel.FromArticle).ToList();
                

                return Ok(articles);
            }
            else
            {
                var articles = this.articlesData.Articles.All()
                    .Where(a => a.Category.Name == category)
                    .OrderBy(a => a.DateCreated)
                    .Skip(10 * page)
                    .Take(10)
                    .Select(ArticleDataModel.FromArticle).ToList();

                return Ok(articles);
            }
        }
        

        private Category GetCategory(ArticleDataModel dataModel)
        {
            var category = this.articlesData.Categories.All().FirstOrDefault(c => c.Name == dataModel.Category);
            if (category == null)
            {
                category = new Category()
                {
                    Name = dataModel.Category
                };
                this.articlesData.Categories.Add(category);
            }

            return category;
        }

        private ICollection<Tag> GetTags(ArticleDataModel dataModel)
        {
            HashSet<Tag> tags = new HashSet<Tag>();
            var newTagNames = dataModel.Tags.ToList();
            var tagsFromTitle = dataModel.Title.Split(' ');
            newTagNames.AddRange(tagsFromTitle);

            foreach (var newTagName in newTagNames)
            {
                var tag = this.articlesData.Tags.All()
                    .FirstOrDefault(t => t.Name == newTagName);
                if (tag == null)
                {
                    tag = new Tag { Name = newTagName };
                    this.articlesData.Tags.Add(tag);
                }

                tags.Add(tag);
            }
            return tags;
        }
    }
}
