using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.BusinessPipelines.Messages
{
    public class DataMessage : EventArgs
    {
        public object Data { get; set; }
    }

    public class DataMessage<T> : EventArgs
    {
        public T Data { get; set; }
    }

}