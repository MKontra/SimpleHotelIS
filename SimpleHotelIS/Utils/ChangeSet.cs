using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.Utils
{
    public class ChangeSet<T> where T: class, new()
    {
        IDictionary<String, Object> properties = new Dictionary<String, Object>();
        public ChangeSet()
        {
        }
    }
}