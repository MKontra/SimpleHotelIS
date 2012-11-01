using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using SimpleHotelIS.BusinessPipelines.Messages;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.Authorization.Requests;
using SimpleHotelIS.BusinessPipelines.Interfaces;

namespace SimpleHotelIS.BusinessPipelines.Actions
{
    public class AuthorizationAction<T> : IAuthorizationAction<T> where T: class, new()
    {
        public event EventHandler<AuthorizationResultMessage> OutData;

        private CrudAutorizationActionDesc descr;
        private IAuthorizationProvider provider;

        public AuthorizationAction (CrudAutorizationActionDesc descr, IAuthorizationProvider provider)
	    {
            this.descr = descr;
            this.provider = provider;
	    }



        public void Invoke(object source, ResourceRequestMessage rrm)
        {
            AuthorizationResult ar = provider.authorize(rrm.Request);
            if (ar.failed())
                OutData(this, new AuthorizationResultMessage { OriginalRequest = rrm.Request, Result = "Access Denied" });
            else
                OutData(this, new AuthorizationResultMessage { OriginalRequest = rrm.Request, Result = "Ok" });
        }
    }
}