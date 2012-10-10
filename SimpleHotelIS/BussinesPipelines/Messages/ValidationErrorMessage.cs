using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHotelIS.BussinesPipelines.Messages
{
    public class ValidationErrorMessage : ErrorMessage
    {
        private EntityValidationResult evr;

        public ValidationErrorMessage(EntityValidationResult evr)
        {
            // TODO: Complete member initialization
            this.evr = evr;
        }
    }
}
