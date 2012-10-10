using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleHotelIS.Repositories
{
    public static class IDbSetToIRepositoryExtension
    {
        public static IRepository<T> AsIRepository<T>(this IDbSet<T> dbset) where T: class, new()
        {
            return new DbSetRepository<T>(dbset);
        }
    }
}