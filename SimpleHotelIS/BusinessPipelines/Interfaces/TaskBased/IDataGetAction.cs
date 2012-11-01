using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IDataGetAction<T> : IFuncTask<T, object>
        where T: class, new()
    {
    }
}
