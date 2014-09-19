using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MusicStore.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private IMusicStoreDbContext context;
        private IDbSet<T> set;

        public Repository()
            :this(new MusicStoreDbContext())
        {

        }
        public Repository(IMusicStoreDbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }
        public IQueryable<T> All()
        {
            return this.set;
        }

        public void Add(T entity)
        {
            this.ChangeState(entity, EntityState.Added);
        }

        public void Delete(T entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public void Update(T entity)
        {
            this.ChangeState(entity, EntityState.Modified);
        }

        public void Detach(T entity)
        {
            this.ChangeState(entity, EntityState.Detached);
        }

        private void ChangeState(T entity, EntityState state)
        {
            var entry = this.context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
