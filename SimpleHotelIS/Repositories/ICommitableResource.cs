using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.Repositories
{
    public interface ICommitableResource<T> : IDisposable
    {
        T getResource();
        void commit();
    }
}
