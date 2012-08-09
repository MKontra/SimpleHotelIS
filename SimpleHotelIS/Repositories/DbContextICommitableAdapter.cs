using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace SimpleHotelIS.Repositories
{
    class DbContextICommitableAdapter<T> : ICommitableResource<DbContext> where T: DbContext, new()
    {

        protected DbContext dbc;

        public DbContextICommitableAdapter()
        {
            this.dbc = new T();
        }

        public void commit()
        {
            dbc.SaveChanges();
        }

        public void Dispose()
        {
            dbc.Dispose();
        }

        public DbContext getResource()
        {
            return dbc;
        }
    }
}