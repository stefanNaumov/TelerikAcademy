using Articles.Data.Repositories;
using Articles.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Data
{
    public class ArticlesData : IArticlesData
    {
        private Dictionary<Type, object> repositories;
        private DbContext context;

        public ArticlesData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Article> Articles
        {
            get { return this.GetRepository<Article>(); }
        }

        public IRepository<Category> Categories
        {
            get { return this.GetRepository<Category>(); }
        }

        public IRepository<Comment> Comments
        {
            get { return this.GetRepository<Comment>(); }
        }

        public IRepository<Like> Likes
        {
            get { return this.GetRepository<Like>(); }
        }

        public IRepository<Tag> Tags
        {
            get { return this.GetRepository<Tag>(); }
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        private IRepository<T> GetRepository<T>() where T: class
        {
            var typeOfRepo = typeof(T);

            if (!(this.repositories.ContainsKey(typeOfRepo)))
            {
                var newRepo = Activator.CreateInstance(typeof
                    (Repository<T>), context);

                this.repositories.Add(typeOfRepo, newRepo);
            }

            return (IRepository <T>) this.repositories[typeOfRepo];
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
    }
}
