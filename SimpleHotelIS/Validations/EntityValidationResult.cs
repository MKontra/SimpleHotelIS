using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Validation;

namespace SimpleHotelIS.Validations
{
    public class EntityValidationResult
    {
        private System.Data.Entity.Validation.DbEntityValidationResult dbEntityValidationResult;

        public ICollection<DbValidationError> validationErrors;

        public  ICollection<DbValidationError>  ValidationErrors
        {
            get { return dbEntityValidationResult.ValidationErrors; }
        }
        

        public EntityValidationResult(System.Data.Entity.Validation.DbEntityValidationResult dbEntityValidationResult)
        {
            // TODO: Complete member initialization
            this.dbEntityValidationResult = dbEntityValidationResult;
        }
    }
}
