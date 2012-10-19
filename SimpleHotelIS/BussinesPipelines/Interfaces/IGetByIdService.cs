using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BussinesPipelines.Interfaces
{
    public interface IGetByIdService<T, TDto> 
        where T: class, new()
        where TDto: class, new()
    {

        TDto invoke(object source, int id);
    }
}
