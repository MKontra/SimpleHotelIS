using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BussinesPipelines.Interfaces
{
    interface IAction
    {
        String Name { get; set; }
        void Invoke(Object source, EventArgs arg);
    }
}
