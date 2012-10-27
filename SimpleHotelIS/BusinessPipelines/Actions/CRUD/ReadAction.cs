using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.BusinessPipelines.Interfaces;
using SimpleHotelIS.BusinessPipelines.Messages;

namespace SimpleHotelIS.BusinessPipelines.Actions.CRUD
{
    public class ReadAction<T> : IDataAccessAction<T> where T : class, new()
    {
        private IModelStore ims;

        public ReadAction(IModelStore ims)
        {
            this.ims = ims;
        }

        public void Invoke(object source, Messages.DataMessage arg)
        {
            OutData(this, new EntityMessage<T> { Entity = ims.Repository<T>().getById(arg.Data) });
        }

        public event EventHandler<Messages.EntityMessage<T>> OutData = delegate { };
        public event EventHandler<Messages.StatusMessage> OutError = delegate { };
    }
}