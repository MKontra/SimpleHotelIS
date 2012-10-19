using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.DTO
{
    public interface IEntityConvertible<T, DtoT>
    {
        T ToEntity();
    }
}
