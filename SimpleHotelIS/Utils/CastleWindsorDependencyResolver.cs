using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;


namespace SimpleHotelIS.Utils
{
    public class CastleWindsorDependencyResolver : System.Web.Http.Dependencies.IDependencyResolver
    {
        private readonly IWindsorContainer _container;

        public CastleWindsorDependencyResolver(IWindsorContainer container)
        {
            _container = container;
        }

        public IDependencyScope BeginScope()
        {
            return new WindsorDependencyScope(_container);
        }

        public object GetService(Type serviceType)
        {
            return _container.Kernel.HasComponent(serviceType)
                       ? _container.Resolve(serviceType)
                       : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose()
        {
        }
    }

    public class WindsorDependencyScope : IDependencyScope
    {
        private readonly IWindsorContainer _container;
        private readonly IDisposable _scope;
        private bool _disposed;

        public WindsorDependencyScope(IWindsorContainer container)
        {
            _container = container;
            _scope = _container.BeginScope();
        }

        public object GetService(Type serviceType)
        {
            EnsureNotDisposed();
            return _container.Kernel.HasComponent(serviceType)
                       ? _container.Kernel.Resolve(serviceType)
                       : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            EnsureNotDisposed();
            return _container.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            if (_disposed) return;

            _scope.Dispose();
            _disposed = true;
            GC.SuppressFinalize(this);
        }

        private void EnsureNotDisposed()
        {
            if (_disposed) throw new ObjectDisposedException("WindsorDependencyScope");
        }
    }
}
