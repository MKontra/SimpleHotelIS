using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    interface IInputValidationAction : IActionTask<object>
    {
    }

    interface IInputValidationAction<T> : IActionTask<T>
        where T: class, new()
    {
    }
}
