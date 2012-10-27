using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;
using SimpleHotelIS.Authorization;
using System.Threading.Tasks;

namespace SimpleHotelIS.BusinessPipelines.Actions.TaskBased
{
    public class AuthorizationTask : IAuthorizationAction
    {
        private IAuthorizationProvider provider;

        public AuthorizationTask(IAuthorizationProvider provider)
	    {
            this.provider = provider;
	    }

        public System.Threading.Tasks.Task<Authorization.AuthorizationResult> GetTask(Authorization.Requests.ResourceRequest arg1)
        {
            return new Task<Authorization.AuthorizationResult>(
                () =>
                    {
                        return provider.authorize(arg1);
                    }
        );
        }
    }
}