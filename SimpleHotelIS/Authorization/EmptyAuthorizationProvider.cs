using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.Authorization
{
    public class EmptyAuthorizationProvider : IAuthorizationProvider
    {
        public AuthorizationResult authorize(System.Security.Principal.IPrincipal invoker, Requests.ResourceRequest resourceRequest)
        {
            return new AuthorizationResult();
        }
    }
}