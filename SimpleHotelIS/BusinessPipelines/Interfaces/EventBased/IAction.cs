using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IAction<TArgumentType> where TArgumentType: EventArgs
    {
        void Invoke(Object source, TArgumentType arg);
    }
}
