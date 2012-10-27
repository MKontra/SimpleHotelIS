using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.Repositories;

namespace SimpleHotelIS.Validations
{
    public class ModelStoreBusinessValidationProvider : IBusinessValidationProvider
    {
        private IModelStore ims;
        public ModelStoreBusinessValidationProvider(IModelStore ims)
        {
            this.ims = ims;
        }

        public EntityValidationResult validate(object o)
        {
            throw new NotImplementedException();
        }

        public EntityValidationResult validate<T>(T o) where T : class
        {
            throw new NotImplementedException();
        }
    }
}