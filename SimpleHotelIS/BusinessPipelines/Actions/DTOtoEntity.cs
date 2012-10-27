using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Messages;
using SimpleHotelIS.DTO;

namespace SimpleHotelIS.BusinessPipelines.Actions
{
    public class DTOtoEntity<T, DtoT> 
        where T :class, new() 
        where DtoT: class, new() 
    {

            public event EntityHandler<T> OutEntity = delegate { };
            public event ErrorHandler OutErr = delegate { }; 

            public DTOtoEntity()
            {
            }

            public void Invoke(Object source, EntityMessage<DtoT> eam)
            {
                IEntityConvertible<T,DtoT> ec = (IEntityConvertible<T,DtoT>) eam.Entity;

                if ( ec == null ) OutErr(this, null);

                T entity = ec.ToEntity();

                OutEntity(this, new EntityMessage<T> { Entity = entity });
            }

        }

}