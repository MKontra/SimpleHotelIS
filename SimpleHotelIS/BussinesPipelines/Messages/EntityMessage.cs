using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.BussinesPipelines.Messages
{
    public class EntityMessage<T> : EventArgs where T : class, new()
    {
        public T Entity { get; set; }
    }

    public class EntityMessage : EventArgs
    {
        public Type EntityType { get; set; }
        public Object Entity { get; set; }
    }
}