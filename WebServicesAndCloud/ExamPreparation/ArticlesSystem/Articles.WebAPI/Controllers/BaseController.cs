
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Articles;
using Articles.Data;

namespace Articles.WebAPI.Controllers
{
    public class BaseController : ApiController
    {
        protected IArticlesData articlesData;

        public BaseController(IArticlesData data)
        {
            this.articlesData = data;
        }
    }
}