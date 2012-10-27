using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BusinessPipelines.Interfaces
{
    public interface IGetByIdService<T, TDto> 
        where T: class, new()
        where TDto: class, new()
    {

        TDto Invoke(object source, Object pKey);
    }
}
