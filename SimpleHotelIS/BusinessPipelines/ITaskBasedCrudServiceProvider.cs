using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;
using SimpleHotelIS.DTO;

namespace SimpleHotelIS.BusinessPipelines
{
    public interface ITaskBasedCrudServiceProvider<T, TDto>
        where T: class, new()
        where TDto : class, IEntityConvertible<T, TDto>, new()
    {
        IGetByIdServiceTask<T, TDto> CreateIGetByIdServiceTask();
        IAsQueryableServiceTask<T, TDto> CreateIAsQueryableServiceTask();
        IDeleteServiceTask<T, TDto> CreateIDeleteServiceTask();
        IUpdateServiceTask<T, TDto> CreateIUpdateServiceTask();
        ICreateServiceTask<T, TDto> CreateICreateServiceTask();
    }
}
