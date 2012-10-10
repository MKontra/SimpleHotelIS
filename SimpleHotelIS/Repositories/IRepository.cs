using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.Repositories
{

    public interface IRepository
    {
        IQueryable getQueryable();

        Object getById(Object pKey);
        void add(Object obj);
        void delete(Object pKey);
        void update(Object obj);
    }

    public interface IRepository<T>  where T: class
    {
        IQueryable<T> getQueryable();

        T getById(Object pKey);
        void add(T obj);
        void delete(Object pKey);
        void update(T obj);
    }
}
