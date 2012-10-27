using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;

namespace SimpleHotelIS.BusinessPipelines
{
    interface ITaskBasedCrudServiceProvider<T, TDto>
        where T: class, new()
        where TDto: class, new()
    {
        IGetByIdServiceTask<T, TDto> CreateIGetByIdServiceTask();
        IAsQueryableServiceTask<T, TDto> CreateIAsQueryableServiceTask();
        IDeleteServiceTask<T, TDto> CreateIDeleteServiceTask();
        IUpdateServiceTask<T, TDto> CreateIUpdateServiceTask();
        ICreateServiceTask<T, TDto> CreateICreateServiceTask();
    }
}
