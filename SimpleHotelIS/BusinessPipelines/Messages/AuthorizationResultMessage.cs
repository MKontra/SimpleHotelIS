using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.Authorization.Requests;

namespace SimpleHotelIS.BusinessPipelines.Messages
{
    public class AuthorizationResultMessage : EventArgs
    {
        public ResourceRequest OriginalRequest { get; set; }
        public string Result { get; set; }
    }
}