using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SimpleHotelIS.Models;

namespace SimpleHotelIS.Repositories
{
    class hotelEntitiesDefault : DbContextICommitableAdapter<hotelEntities>
    {
        public hotelEntitiesDefault()
        {
            this.dbc = new hotelEntities("named");
        }
    }
}