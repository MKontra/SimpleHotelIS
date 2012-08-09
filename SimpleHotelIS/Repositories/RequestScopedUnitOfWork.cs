using System.Web;
using SimpleHotelIS.Repositories;
using System;

namespace SimpleHotelIS.Repositories
{

    public class RequestScopedUnitOfWork<T, K> : IUnitOfWork<T, K> where T : ICommitableResource<K>, new()
    {

        private const string ItemsKey = "__RequestScopedUnitOfWork__";
        private ICommitableResource<K> managedReference;

        protected RequestScopedUnitOfWork()
        {
        }

        protected RequestScopedUnitOfWork(ICommitableResource<K> managedReference)
        {
            this.managedReference = managedReference;
        }

        public static IUnitOfWork<T, K> Current()
        {
                var current = (RequestScopedUnitOfWork<T,K>)HttpContext.Current.Items[ItemsKey];

                if (current == null)
                {
                    HttpContext.Current.Items[ItemsKey] = current = new RequestScopedUnitOfWork<T,K>(new T());
                }

                return current;
        }

        public K getStoredReference()
        {
            return managedReference.getResource();
        }

        public void SaveChanges()
        {
            managedReference.commit();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    managedReference.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}