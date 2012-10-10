using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleHotelIS.Repositories
{

    public class DbSetRepository
    {
    }

    public class DbSetRepository<T> : IRepository<T> where T: class, new()
    {
        private IDbSet<T> dbSet;

        public DbSetRepository(IDbSet<T> dbSet)
        {
            this.dbSet = dbSet;
        }

        public IQueryable<T> getQueryable()
        {
            return dbSet;
        }

        public T getById(object pKey)
        {
            return dbSet.Find(new object[] { pKey });
        }

        public void add(T obj)
        {
            dbSet.Add(obj);
        }

        public void delete(object pKey)
        {
            dbSet.Remove(getById(pKey));
        }

        public void update(T obj)
        {
            //do nothing -- updates are tracked
        }
    }
}