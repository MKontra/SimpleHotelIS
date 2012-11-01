using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IInputValidationAction : IActionTask<object>
    {
    }

    public interface IInputValidationAction<T> : IActionTask<T>
        where T: class, new()
    {
    }
}
