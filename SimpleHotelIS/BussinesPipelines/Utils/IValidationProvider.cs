using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BussinesPipelines
{
    public interface IValidationProvider
    {
        EntityValidationResult validate(Object o);
        EntityValidationResult validate<T>(T o) where T : class;
    }
}
