using System;

namespace SimpleHotelIS.Repositories
{
    public interface IUnitOfWork<T,K> : IDisposable where T : ICommitableResource<K>, new()
    {
        K getStoredReference();
        void SaveChanges();
    }
}