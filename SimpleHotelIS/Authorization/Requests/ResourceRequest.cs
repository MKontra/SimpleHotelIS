using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.Authorization.Requests
{
    public class ResourceRequest
    {
        private CrudAutorizationActionDesc descr;

        public ResourceRequest(CrudAutorizationActionDesc descr)
        {
            // TODO: Complete member initialization
            this.descr = descr;
        }
    }
}