using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web;

namespace SimpleHotelIS.ApiControllers
{
    public class HelpController : ApiController
    {
        // GET api/<controller>
        public System.Net.Http.HttpResponseMessage Get()
        {
            var response = new System.Net.Http.HttpResponseMessage(HttpStatusCode.Redirect);
            response.Headers.Location = new Uri("ApiHelp", UriKind.Relative); 
            return response;
        }
    }
}