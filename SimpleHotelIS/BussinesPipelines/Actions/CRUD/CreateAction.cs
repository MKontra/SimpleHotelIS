using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.BussinesPipelines.Messages;
using SimpleHotelIS.BussinesPipelines.Interfaces;

namespace SimpleHotelIS.BussinesPipelines.Actions.CRUD
{
    public class CreateAction<T> : IDataCreationAction<T> where T : class, new()
    {
        public event StatusHandler OutStatus = delegate { };
        public event EntityHandler<T> OutNew = delegate { };

        private IModelStore ims;

        public CreateAction(IModelStore ims)
        {
            this.ims = ims;
        }

        public void Invoke(Object sender, EntityMessage<T> em)
        {
            ims.Repository<T>().add(em.Entity);
        }

    }
}