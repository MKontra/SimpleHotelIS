using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;
using SimpleHotelIS.Validations;
using System.Threading.Tasks;

namespace SimpleHotelIS.BusinessPipelines.Actions.TaskBased
{

    public class BusinessValidationTask<T> : IBusinessValidationAction<T>
        where T : class, new()
    {
        private IBusinessValidationProvider ivp;

        public BusinessValidationTask(IBusinessValidationProvider ivp)
        {
            this.ivp = ivp;
        }

        public System.Threading.Tasks.Task GetTask(T arg1)
        {
            return new Task(
                () =>
                {
                    EntityValidationResult evr = ivp.validate(arg1);
                    if (evr.ValidationErrors.Count > 0)
                    {
                        throw new Exception("Validation Error " + evr.ToString());
                    }
                });
        }
    }

}