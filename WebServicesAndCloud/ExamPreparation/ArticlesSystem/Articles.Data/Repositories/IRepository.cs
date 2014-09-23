using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Data.Repositories
{
    public interface IRepository<T> where T: class
    {
        void Add(T entity);

        T Find(object id);

        IQueryable<T> All();

        void Update(T entity);

        T Delete(T entity);

        T Delete(object id);

        void Detach(T entity);

        int SaveChanges(T entity);
    }
}
