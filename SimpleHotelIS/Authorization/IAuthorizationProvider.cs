using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.Authorization
{
    public interface IAuthorizationProvider
    {
        AuthorizationResult authorize(System.Security.Principal.IPrincipal invoker, Requests.ResourceRequest resourceRequest);
    }
}
