using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IActionWithErrorEvent<TArgument, TOutEventArg1> : IAction<TArgument>
        where TOutEventArg1 : EventArgs
        where TArgument : EventArgs
    {
        event EventHandler<TOutEventArg1> OutError;
    }

}

