using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace SimpleHotelIS.Authorization.Requests
{
    public class ResourceRequest
    {
        public IPrincipal Requester { get; set; }
    }
}