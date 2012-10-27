using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.Authorization
{
    public class EmptyAuthorizationProvider : IAuthorizationProvider
    {
        public AuthorizationResult authorize( Requests.ResourceRequest resourceRequest)
        {
            return new AuthorizationResult();
        }
    }
}