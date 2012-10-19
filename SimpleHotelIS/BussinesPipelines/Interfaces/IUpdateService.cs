using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BussinesPipelines.Interfaces
{
    public interface IUpdateService<T, TDto>
        where T : class, new()
        where TDto : class, new()
    {
        void Invoke(object source, TDto dto);
    }
}
