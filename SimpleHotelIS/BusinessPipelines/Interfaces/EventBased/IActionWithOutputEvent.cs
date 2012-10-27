using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IActionWithOutputEvent<TArgument, TOutEventArg1> : IAction<TArgument> 
        where TArgument : EventArgs
        where TOutEventArg1: EventArgs
    {
        event EventHandler<TOutEventArg1> OutData;
    }
}
