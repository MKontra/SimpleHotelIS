using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using SimpleHotelIS.BussinesPipelines.Messages;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.Authorization.Requests;
using SimpleHotelIS.BussinesPipelines.Interfaces;

namespace SimpleHotelIS.BussinesPipelines.Actions
{
    public class CrudAuthorizationAction<T> : IAuthorizationAction<T> where T: class, new()
    {
        public event EntityHandler<T> OutEntity = delegate { };
        public event AuthorizationErrorHandler OutErr = delegate { };

        private CrudAutorizationActionDesc descr;
        private IAuthorizationProvider provider;

        public CrudAuthorizationAction (CrudAutorizationActionDesc descr, IAuthorizationProvider provider)
	    {
            this.descr = descr;
            this.provider = provider;
	    }

        public void Invoke(Object source, IPrincipal invoker, EntityMessage<T> ema)
        {
            AuthorizationResult ar = provider.authorize(invoker, new ResourceRequest(descr)); ;
            if (ar.failed())
                OutErr(this, new AuthentizationErrorMessage { Message = "Access Denied" });
            else
                OutEntity(this, new EntityMessage<T> { Entity = ema.Entity });
        }

    }
}