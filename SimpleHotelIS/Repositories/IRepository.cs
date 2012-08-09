using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.Repositories
{
    public interface IRepository<T>  where T: class
    {
        IQueryable<T> getQueryable();

        T getById(Object pKey);
        void add(T obj);
        void delete(Object pKey);
        void update(T obj);
    }
}
