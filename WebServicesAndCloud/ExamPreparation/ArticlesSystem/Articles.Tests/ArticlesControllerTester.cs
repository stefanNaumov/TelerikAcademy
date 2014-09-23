using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using Articles.Data.Repositories;
using Articles.Models;
using System.Linq;
using Articles.Data;
using Articles.WebAPI.Controllers;
using System.Web.Http;
using System.Threading;
using Articles.WebAPI.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;



namespace Articles.Tests
{
    /// <summary>
    /// Summary description for ArticlesControllerTester
    /// </summary>
    [TestClass]
    public class ArticlesControllerTester
    {
       [TestMethod]
        public void GetAllArticlesFromDbShouldReturnArticles()
        {
            var repository = Mock.Create<IRepository<Article>>();

            Article[] articles = this.GenerateValidTestArticles(1);
           var articleData = Mock.Create<IArticlesData>();

           Mock.Arrange(() => repository.All())
           .Returns(() => articles.AsQueryable());

           Mock.Arrange(() => articleData.Articles)
               .Returns(() => repository);

           var articlesController = new ArticlesController(articleData);
           this.SetupController(articlesController);

           var actionResult = articlesController.All();

           var response = actionResult.ExecuteAsync(CancellationToken.None).Result;

           var actual = response.Content.ReadAsAsync<IEnumerable<ArticleDataModel>>().Result.Select(a => a.Id).ToList();

           var expected = articles.AsQueryable().Select(a => a.Id).ToList();

           CollectionAssert.AreEquivalent(actual, expected);
        }

       private void SetupController(ApiController controller)
       {
           string serverUrl = "http://test-url.com";

           //Setup the Request object of the controller
           var request = new HttpRequestMessage()
           {
               RequestUri = new Uri(serverUrl)
           };
           controller.Request = request;

           //Setup the configuration of the controller
           var config = new HttpConfiguration();
           config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/articles/{id}",
               defaults: new { id = RouteParameter.Optional });
           controller.Configuration = config;

           //Apply the routes of the controller
           controller.RequestContext.RouteData =
               new HttpRouteData(
                   route: new HttpRoute(),
                   values: new HttpRouteValueDictionary
                    {
                        { "controller", "articles" }
                    });
       }

       private Article[] GenerateValidTestArticles(int count)
       {
           Article[] articles = new Article[count];
           var category = new Category()
           {
               Id = 1,
               Name = "Test Category"
           };

           var tags = new Tag[]{
                new Tag(){
                     Id = 1,
                     Name="tag"
                }
            };

           for (int i = 0; i < count; i++)
           {
               var article = new Article
               {
                   Id = i,
                   Title = " Title #" + i,
                   Content = "The Content #" + i,
                   Category = category,
                   DateCreated = DateTime.Now,
                   Tags = tags,
               };
               articles[i] = article;
           }

           return articles;
       }
    }
}
