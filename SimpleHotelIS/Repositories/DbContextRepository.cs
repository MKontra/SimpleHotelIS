using SimpleHotelIS.Repositories;
using System.Data.Entity;

namespace SimpleHotelIS.Repositories
{

    public class DbContextRepository<T> : IRepository<T> where T : class
    {

        private DbContext context;
        private IDbSet<T> set;

        public DbContextRepository(DbContext dbc)
        {
            this.context = dbc;
            this.set = dbc.Set<T>();
        }
        public System.Linq.IQueryable<T> getQueryable()
        {
            return set;
        }

        public T getById(object pKey)
        {
            return set.Find(new object[] { pKey });
        }

        public void add(T obj)
        {
            set.Add(obj);
        }

        public void delete(object pKey)
        {
            set.Remove(this.getById(pKey));
        }

        public void update(T obj)
        {
            context.Entry<T>(obj).State = System.Data.EntityState.Modified;
        }
    }

}