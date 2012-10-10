using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BussinesPipelines.Messages;
using SimpleHotelIS.Repositories;

namespace SimpleHotelIS.BussinesPipelines.Actions
{
    public class EntityActionIModelStoreProcessor
    {

        private IModelStore ims;

        public EntityActionIModelStoreProcessor(IModelStore ims)
        {
            this.ims = ims;
        }
        public void Invoke(Object sender, EntityActionMessage eam)
        {
            if (eam.Action == "Create")
                ims.Repository(eam.EntityType).add(eam.Entity);
        }
    }
}