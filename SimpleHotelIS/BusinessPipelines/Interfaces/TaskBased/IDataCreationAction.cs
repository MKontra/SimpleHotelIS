using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IDataCreationAction<T> : IFuncTask<T, T>
        where T: class, new()
    {
    }
}
