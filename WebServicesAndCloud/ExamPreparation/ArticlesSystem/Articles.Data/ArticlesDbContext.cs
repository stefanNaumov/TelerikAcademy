using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Infrastructure;
using Articles.Models;
using Articles.Data.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Articles.Data
{
    public class ArticlesDbContext : IdentityDbContext<User>
    {
        public ArticlesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ArticlesDbContext, Configuration>());
            base.Configuration.ProxyCreationEnabled = false;
        }

        public static ArticlesDbContext Create()
        {
            return new ArticlesDbContext();
        }

        public IDbSet<Alert> Alerts { get; set; }
        public IDbSet<Article> Articles { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Like> Likes { get; set;}

        public IDbSet<Tag> Tags { get; set; }

        //public IDbSet<User> Users { get; set; }
    }
}
