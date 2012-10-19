using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BussinesPipelines.Messages;

namespace SimpleHotelIS.BussinesPipelines.Interfaces
{
    public interface IBussinessValidation
        {

            event EntityActionHandler OutEntity;
            event ValidationErrorHandler OutErr;

            void Invoke(Object source, EntityActionMessage eam);
        }

    public interface IBussinessValidation<T> where T : class, new()
        {

            event EntityActionHandler<T> OutEntity;
            event ValidationErrorHandler OutErr;

            void Invoke(Object source, EntityActionMessage<T> eam);
        }
   
}
