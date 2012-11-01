using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IAsQueryableServiceTask<T, TDto> : IFuncTask<IQueryable<TDto>>
        where T: class, new()
        where TDto: class, new()
    {
    }
}
