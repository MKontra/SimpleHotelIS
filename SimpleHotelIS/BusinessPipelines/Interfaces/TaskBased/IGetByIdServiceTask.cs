using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.DTO;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    interface IGetByIdServiceTask<T, TDto> : IFuncTask<T, object>
        where T: class, new()
        where TDto: class, IEntityConvertible<T, TDto>,new()
    {
    }
}
