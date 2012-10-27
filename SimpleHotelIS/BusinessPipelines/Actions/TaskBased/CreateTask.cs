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
    public class CreateTask<T> : IDataCreationAction<T>
        where T: class, new()
    {

        private IModelStore ims;

        public CreateTask(IModelStore ims)
        {
            this.ims = ims;
        }


        public Task<T> GetTask(T arg1)
        {
            return new Task<T>(
                () =>
                {
                    ims.Repository<T>().add(arg1);
                    ims.SaveChanges();
                    return arg1;
                });
        }
    }
}