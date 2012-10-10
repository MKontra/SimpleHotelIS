using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.OData;

namespace SimpleHotelIS.BussinesPipelines.Messages
{

    public class EntityActionMessage<T> : EventArgs where T: class, new()
    {
        public string Action { get; set; }
        public Delta<T> Entity { get; set; }
    }

    public class EntityActionMessage : EventArgs
    {
        public string Action { get; set; }
        public Type EntityType { get; set; }
        public Object Entity { get; set; }
    }
}
