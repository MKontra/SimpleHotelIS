using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BussinesPipelines.Messages;

namespace SimpleHotelIS.BussinesPipelines.Interfaces
{
    public interface IDataCreationAction<T>  where T: class, new()
    {
        event StatusHandler OutStatus;
        event EntityHandler<T> OutNew;

        void Invoke(Object sender, EntityMessage<T> em);
    }
}
