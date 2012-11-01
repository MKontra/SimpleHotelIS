using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.Authorization.Requests;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IAuthorizationAction : IFuncTask<AuthorizationResult, ResourceRequest>
    {
    }

    public interface IAuthorizationAction<T> : IFuncTask<AuthorizationResult, ResourceRequest>
        where T: class, new()
    {
    }
}
