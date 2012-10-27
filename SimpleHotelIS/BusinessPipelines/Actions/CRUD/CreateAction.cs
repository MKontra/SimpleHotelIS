using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.BusinessPipelines.Messages;
using SimpleHotelIS.BusinessPipelines.Interfaces;

namespace SimpleHotelIS.BusinessPipelines.Actions.CRUD
{
    public class CreateAction<T> : IDataCreationAction<T> where T : class, new()
    {

        private IModelStore ims;

        public CreateAction(IModelStore ims)
        {
            this.ims = ims;
        }

        public void Invoke(Object sender, EntityMessage<T> em)
        {
            ims.Repository<T>().add(em.Entity);
        }


        public event EventHandler<EntityMessage<T>> OutData = delegate { };

        public event EventHandler<StatusMessage> OutError = delegate { };
    }
}