using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BussinesPipelines.Actions;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.BussinesPipelines.Interfaces;
using SimpleHotelIS.BussinesPipelines.Actions.CRUD;
using SimpleHotelIS.Authorization;

namespace SimpleHotelIS.BussinesPipelines.Facades
{
    public class DefaultEntityCreate<T, DtoT> : ICreateService<T, DtoT>
        where T: class, new()
        where DtoT: class, new()
    {

        private DTOtoEntity<T, DtoT> conversionHandler;
        private IAuthorizationAction<T> authorizationHandler;
        private IValidationAction<T> validationHandler;
        private IDataCreationAction<T> creationHandler;

        public DefaultEntityCreate
            (IAuthorizationProvider author, IValidationProvider validator, IModelStore ims)
        {
            conversionHandler = new DTOtoEntity<T, DtoT>();
            authorizationHandler = new CrudAuthorizationAction<T>(CrudAutorizationActionDesc.Create, author);
            validationHandler = new InputValidationAction<T>(validator);
            creationHandler = new CreateAction<T>(ims);

            //chain it
            conversionHandler.OutEntity += (sender, args) => { authorizationHandler.Invoke(sender, null, args); };
            //authorizationHandler.OutEntity += (src, args) => { validationHandler.Invoke(src, null); };
            //validationHandler.OutEntity += creationHandler.Invoke;
            authorizationHandler.OutEntity += creationHandler.Invoke;
            ims.SaveChanges();
        }

        public void Invoke(object source, DtoT dto)
        {
            conversionHandler.Invoke(this, new Messages.EntityMessage<DtoT> { Entity = dto });
        }
    }
}