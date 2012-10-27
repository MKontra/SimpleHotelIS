using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.Authorization.Requests
{
    public class CreateFromDtoRequest<TDto> : ResourceRequest
    {
        public TDto Dto { get; set; }
    }
}