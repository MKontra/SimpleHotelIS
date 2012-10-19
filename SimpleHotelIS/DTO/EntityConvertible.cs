using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.DTO
{
    interface EntityConvertible<T, DtoT>
    {
        T ToEntity();
    }
}
