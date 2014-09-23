using Articles.Data.Repositories;
using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Data
{
    public class AlertsData : IAlertsData
    {
        private Dictionary<Type, object> repositories;
        private ArticlesDbContext context;

        public AlertsData(ArticlesDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Alert> Alerts
        {
            get { return this.GetRepository<Alert>(); }
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
