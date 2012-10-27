using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.Authorization.Requests;

namespace SimpleHotelIS.BusinessPipelines.Messages
{
    public class ResourceRequestMessage : EventArgs
    {

        public ResourceRequest Request { get; set; }

        public ResourceRequestMessage(ResourceRequest request )
        {
            this.Request = request;
        }
    }
}