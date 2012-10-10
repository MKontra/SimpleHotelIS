using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BussinesPipelines.Messages;

namespace SimpleHotelIS.BussinesPipelines
{
    public delegate void EntityActionHandler(Object sender, EntityActionMessage eam);
    public delegate void EntityActionHandler<T>(Object sender, EntityActionMessage<T> eam) where T: class, new();

    public delegate void ValidationErrorHandler(Object sender, ValidationErrorMessage em);
}