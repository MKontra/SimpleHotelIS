using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BusinessPipelines.Messages;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IDataAccessAction:
        IActionWithErrorAndOutEvent<DataMessage, EntityActionMessage, ValidationErrorMessage>
    { }


    public interface IDataAccessAction<T>:
        IActionWithErrorAndOutEvent<DataMessage, EntityMessage<T>, StatusMessage>
        where T : class, new()
    { }
}
