﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BussinesPipelines.Messages
{
    public class ErrorMessage : EventArgs
    {
        public string Message { get; set; }
        //ValidationErrors
    }
}
