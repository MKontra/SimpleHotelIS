using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    interface IBusinessValidationAction : IActionTask<object>
    {
    }

    interface IBusinessValidationAction<T> : IActionTask<T>
        where T : class, new()
    {
    }
}


