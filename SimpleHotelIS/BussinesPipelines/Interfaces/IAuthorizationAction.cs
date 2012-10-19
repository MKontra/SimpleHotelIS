using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using SimpleHotelIS.BussinesPipelines.Messages;

namespace SimpleHotelIS.BussinesPipelines.Interfaces
{
    public interface IAuthorizationAction<T> where T : class, new()
    {
        event EntityHandler<T> OutEntity;
        event AuthorizationErrorHandler OutErr;

        void Invoke(Object source, IPrincipal invoker, EntityMessage<T> ema);
    }
}
