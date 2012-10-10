using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BussinesPipelines.Interfaces;
using SimpleHotelIS.BussinesPipelines.Messages;

namespace SimpleHotelIS.BussinesPipelines.Actions
{

    public class InputValidationAction<T> : IValidationAction<T> where T: class, new()
    {
        public event EntityActionHandler<T> OutEntity = delegate { };
        public event ValidationErrorHandler OutErr = delegate { };

        private IValidationProvider ivp;

        public InputValidationAction(IValidationProvider ivp)
        {
            this.ivp = ivp;
        }

        public void Invoke(Object source, EntityActionMessage<T> eam)
        {
            EntityValidationResult evr = ivp.validate(eam.Entity);
            if (evr.ValidationErrors.Count == 0)
            {
                OutEntity(this, eam);
            }
            else
            {
                OutErr(this, new ValidationErrorMessage(evr));
            }
        }

    }

    public class InputValidationAction : IValidationAction
    {
        public event EntityActionHandler OutEntity = delegate { };
        public event ValidationErrorHandler OutErr = delegate { };

        private IValidationProvider ivp;

        public InputValidationAction(IValidationProvider ivp)
        {
            this.ivp = ivp;
        }

        public void Invoke(Object source, EntityActionMessage eam)
        {
            EntityValidationResult evr = ivp.validate(eam.Entity);
            if (evr.ValidationErrors.Count == 0)
            {
                OutEntity(this, eam);
            }
            else
            {
                OutErr(this, new ValidationErrorMessage(evr));
            }
        }

    }
}