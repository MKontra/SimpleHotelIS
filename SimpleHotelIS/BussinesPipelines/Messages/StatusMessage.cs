﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleHotelIS.BussinesPipelines.Messages
{
    public class StatusMessage : EventArgs
    {
        public string Status { get; set; }
    }
}