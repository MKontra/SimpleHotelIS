using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BussinesPipelines.Messages;
using SimpleHotelIS.DTO;

namespace SimpleHotelIS.BussinesPipelines.Actions
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
                EntityConvertible<T,DtoT> ec = (EntityConvertible<T,DtoT>) eam.Entity;

                if ( ec == null ) OutErr(this, null);

                T entity = ec.ToEntity();

                OutEntity(this, new EntityMessage<T> { Entity = entity });
            }

        }

}