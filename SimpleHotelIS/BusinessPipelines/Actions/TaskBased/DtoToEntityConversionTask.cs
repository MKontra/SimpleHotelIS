using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Messages;
using System.Threading.Tasks;
using SimpleHotelIS.DTO;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;

namespace SimpleHotelIS.BusinessPipelines.Actions.TaskBased
{
    public class DtoToEntityConversionTask<T, TDto> : IDtoToEntityAction<T, TDto>
        where TDto: class, IEntityConvertible<T, TDto>, new()
        where T : class, new()
    {
        public Task<T> GetTask(TDto arg1)
        {
            return new Task<T>(() => arg1.ToEntity());
        }
    }
}