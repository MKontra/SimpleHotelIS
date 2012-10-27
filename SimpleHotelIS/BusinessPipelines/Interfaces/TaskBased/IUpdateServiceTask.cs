using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    interface IUpdateServiceTask<T, TDto> : IFuncTask<T, TDto>
        where T : class, new()
        where TDto : class, new()
    {
    }
}
