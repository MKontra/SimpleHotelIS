using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IActionWithErrorAndOutEvent<TArgument, TOutEvent1, TErrEvent1> : 
        IActionWithOutputEvent<TArgument, TOutEvent1>,
        IActionWithErrorEvent<TArgument, TErrEvent1>
        where
            TArgument : EventArgs
        where
            TOutEvent1 : EventArgs
        where
            TErrEvent1 : EventArgs
    {
    }
}
