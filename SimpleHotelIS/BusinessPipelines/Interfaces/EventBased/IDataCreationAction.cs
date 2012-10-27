using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BusinessPipelines.Messages;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IDataCreationAction:
        IActionWithErrorAndOutEvent<EntityActionMessage, EntityActionMessage, ValidationErrorMessage>
    { }


    public interface IDataCreationAction<T>:
        IActionWithErrorAndOutEvent<EntityMessage<T>, EntityMessage<T>, StatusMessage>
        where T : class, new()
    { }
}
