using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BussinesPipelines.Interfaces
{
    public interface IAsQueryableService<T, TDto>
        where T : class, new()
        where TDto : class, new()
    {
        IQueryable<TDto> invoke(object source);
    }
}
