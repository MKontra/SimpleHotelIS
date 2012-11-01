using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IBusinessValidationAction : IActionTask<object>
    {
    }

    public interface IBusinessValidationAction<T> : IActionTask<T>
        where T : class, new()
    {
    }
}


