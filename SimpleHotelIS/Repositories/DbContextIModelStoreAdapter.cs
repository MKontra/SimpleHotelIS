using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleHotelIS.Repositories
{
    public class DbContextIModelStoreAdapter: IModelStore
    {

        private DbContext dbc;

        public DbContextIModelStoreAdapter(DbContext dbc)
        {
            this.dbc = dbc;
        }



        public IRepository<T> Repository<T>() where T: class, new()
        {
            return dbc.Set<T>().AsIRepository<T>();
        }

        public IRepository Repository(Type type)
        {
            throw new NotImplementedException();
        }


        public void SaveChanges()
        {
            dbc.SaveChanges();
        }


        public T unwrap<T>() where T: class
        {
            return dbc as T;
        }
    }
}