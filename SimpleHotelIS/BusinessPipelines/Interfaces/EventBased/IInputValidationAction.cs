using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BusinessPipelines.Messages;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IBusinessValidationAction :
        IActionWithErrorAndOutEvent<EntityActionMessage, EntityActionMessage, ValidationErrorMessage>
    {}


    public interface IBusinessValidationAction<T> :
        IActionWithErrorAndOutEvent<EntityActionMessage<T>, EntityActionMessage<T>, ValidationErrorMessage>
        where T: class, new()
    {}
}
