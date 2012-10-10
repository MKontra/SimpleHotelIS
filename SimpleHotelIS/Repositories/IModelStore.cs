using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.Repositories
{
    public interface IModelStore //mirrors {Object,Db}Context methods
    {
        IRepository<T> Repository<T>() where T: class, new();
        IRepository Repository(Type type);

        void SaveChanges();
        T unwrap<T>() where T : class;
    }
}
