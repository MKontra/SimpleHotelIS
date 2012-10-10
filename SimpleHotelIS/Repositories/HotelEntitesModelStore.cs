using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.Models;

namespace SimpleHotelIS.Repositories
{
    public class HotelEntitesModelStore : DbContextIModelStoreAdapter
    {
        public HotelEntitesModelStore() : base(new HotelEntities()) { }
    }
}