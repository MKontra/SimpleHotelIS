using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IAsQueryableService<T, TDto>
        where T : class, new()
        where TDto : class, new()
    {
        IQueryable<TDto> Invoke(object source);
    }
}
