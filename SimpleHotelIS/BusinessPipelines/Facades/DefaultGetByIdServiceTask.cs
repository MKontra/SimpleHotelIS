using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;
using SimpleHotelIS.BusinessPipelines.Actions.TaskBased;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.Authorization;
using System.Threading.Tasks;
using SimpleHotelIS.Authorization.Requests;

namespace SimpleHotelIS.BusinessPipelines.Facades
{
    public class DefaultGetByIdServiceTask<T, TDto> : IGetByIdServiceTask<T, TDto>
        where T: class, new()
        where TDto: class, new()
    {

        IAuthorizationAction authorizationTask;
        IDataGetAction<T> dataAccessTask;

        public DefaultGetByIdServiceTask(IAuthorizationProvider author, IModelStore ims)
        {
            authorizationTask = new AuthorizationTask(author);
            dataAccessTask = new ReadTask<T>(ims);
        }

        public System.Threading.Tasks.Task<T> GetTask(object arg1)
        {
            return authorizationTask.GetTask( new ReadByIdRequest{ Id = arg1}).ContinueWith<T>(result => dataAccessTask.GetTask(arg1).Result);
        }
    }
}