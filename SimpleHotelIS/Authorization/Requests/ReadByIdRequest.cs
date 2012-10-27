using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.Authorization.Requests
{
    public class ReadByIdRequest : ResourceRequest
    {
        public Object Id { get; set; }
    }
}