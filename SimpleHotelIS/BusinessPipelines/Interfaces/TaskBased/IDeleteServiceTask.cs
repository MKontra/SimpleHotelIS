using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IDeleteServiceTask<T, TDto> : IActionTask<object>
        where T : class, new()
        where TDto : class, new()
    {
    }
}
