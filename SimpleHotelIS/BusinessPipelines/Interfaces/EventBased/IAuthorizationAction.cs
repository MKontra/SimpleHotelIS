using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using SimpleHotelIS.BusinessPipelines.Messages;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IAuthorizationAction:
        IActionWithOutputEvent<ResourceRequestMessage, AuthorizationResultMessage>
    { }


    public interface IAuthorizationAction<T>:
        IActionWithOutputEvent<ResourceRequestMessage, AuthorizationResultMessage>
        where T : class, new()
    { }
}
