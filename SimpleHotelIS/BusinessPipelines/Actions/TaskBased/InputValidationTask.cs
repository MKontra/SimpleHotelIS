using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;
using SimpleHotelIS.Validations;
using System.Threading.Tasks;

namespace SimpleHotelIS.BusinessPipelines.Actions.TaskBased
{
    public class InputValidationTask<T> : IInputValidationAction<T>
        where T: class, new()
    {
        private IInputValidationProvider ivp;

        public InputValidationTask(IInputValidationProvider ivp)
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
