using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Interfaces;
using SimpleHotelIS.BusinessPipelines.Messages;
using SimpleHotelIS.Validations;

namespace SimpleHotelIS.BusinessPipelines.Actions
{

    public class BusinessValidationAction<T> : IBusinessValidationAction<T> where T : class, new()
    {
        public event EventHandler<EntityActionMessage<T>> OutData = delegate { };
        public event EventHandler<ValidationErrorMessage> OutError = delegate { };

        private IBusinessValidationProvider ivp;

        public BusinessValidationAction(IBusinessValidationProvider ivp)
        {
            this.ivp = ivp;
        }

        public void Invoke(Object source, EntityActionMessage<T> eam)
        {
            EntityValidationResult evr = ivp.validate(eam.Entity);
            if (evr.ValidationErrors.Count == 0)
            {
                OutData(this, eam);
            }
            else
            {
                OutError(this, new ValidationErrorMessage(evr));
            }
        }



    }

    public class BusinessValidationAction : IInputValidationAction
    {

        private IInputValidationProvider ivp;

        public BusinessValidationAction(IInputValidationProvider ivp)
        {
            this.ivp = ivp;
        }

        public event EventHandler<EntityActionMessage> OutData = delegate { };

        public event EventHandler<ValidationErrorMessage> OutError = delegate { };

        public void Invoke(object source, EntityActionMessage arg)
        {
            EntityValidationResult evr = ivp.validate(arg.Entity);
            if (evr.ValidationErrors.Count == 0)
            {
                OutData(this, arg);
            }
            else
            {
                OutError(this, new ValidationErrorMessage(evr));
            }
        }

    }
}