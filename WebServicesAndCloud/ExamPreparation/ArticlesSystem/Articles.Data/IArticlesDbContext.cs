using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Articles.Models;

namespace Articles.Data
{
    public interface IArticlesDbContext
    {
        IDbSet<Article> Articles { get; set; }

        IDbSet<User> Users { get; set; }

        IDbSet<Comment> Comments { get; set; }

        IDbSet<Like> Likes { get; set; }

        IDbSet<Alert> Alerts { get; set; }

        int SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
