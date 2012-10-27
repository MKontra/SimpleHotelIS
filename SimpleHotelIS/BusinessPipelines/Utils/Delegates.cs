using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Messages;

namespace SimpleHotelIS.BusinessPipelines
{
    public delegate void EntityActionHandler(Object sender, EntityActionMessage eam);
    public delegate void EntityActionHandler<T>(Object sender, EntityActionMessage<T> eam) where T: class, new();
    //public delegate EntityActionHandler<T> EventHandler<EntityActionMessage<T>> ;

    public delegate void StatusHandler(Object sender, StatusMessage sm);

    public delegate void EntityHandler(Object sender, EntityMessage eam);
    public delegate void EntityHandler<T>(Object sender, EntityMessage<T> eam) where T : class, new();

    public delegate void ErrorHandler(Object sender, ErrorMessage em);
    public delegate void ValidationErrorHandler(Object sender, ValidationErrorMessage em);
}