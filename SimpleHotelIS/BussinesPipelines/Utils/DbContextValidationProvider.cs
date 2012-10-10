using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Http.ModelBinding;

namespace SimpleHotelIS.BussinesPipelines
{
    public class DbContextValidationProvider : IValidationProvider
    {

        private DbContext dbc;

        public DbContextValidationProvider(DbContext dbc)
        {
            this.dbc = dbc;
        }

        public EntityValidationResult validate(object o)
        {
            return new EntityValidationResult(dbc.Entry(o).GetValidationResult());
        }

        public EntityValidationResult validate<T>(T o) where T : class
        {
            return new EntityValidationResult(dbc.Entry(o).GetValidationResult());
        }
    }
}