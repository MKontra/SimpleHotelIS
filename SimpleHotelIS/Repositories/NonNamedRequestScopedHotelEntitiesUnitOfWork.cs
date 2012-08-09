using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SimpleHotelIS.Models;

namespace SimpleHotelIS.Repositories
{
    class NonNamedRequestScopedHotelEntitiesUnitOfWork : RequestScopedUnitOfWork<DbContextICommitableAdapter<hotelEntities>, DbContext>
    {
    }
}