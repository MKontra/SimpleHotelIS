using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.Authorization
{
    public interface IAuthorizationProvider
    {
        AuthorizationResult authorize(Requests.ResourceRequest resourceRequest);
    }
}
