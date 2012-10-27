using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;
using SimpleHotelIS.Authorization;
using System.Threading.Tasks;
using SimpleHotelIS.Repositories;

namespace SimpleHotelIS.BusinessPipelines.Actions.TaskBased
{

    public class ReadTask<T> : IDataGetAction<T>
        where T : class, new()
    {

        private IModelStore ims;

        public ReadTask(IModelStore ims)
        {
            this.ims = ims;
        }

        public Task<T> GetTask(object arg1)
        {
            return new Task<T>(
                () =>
                {
                    return ims.Repository<T>().getById(arg1);
                });
        }
    }

}