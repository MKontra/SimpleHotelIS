using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.Validations
{
    public interface IBusinessValidationProvider
    {
        EntityValidationResult validate(Object o);
        EntityValidationResult validate<T>(T o) where T : class;
    }
}
