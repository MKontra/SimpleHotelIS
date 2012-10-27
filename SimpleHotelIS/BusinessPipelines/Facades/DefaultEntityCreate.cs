using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Actions;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.BusinessPipelines.Interfaces;
using SimpleHotelIS.BusinessPipelines.Actions.CRUD;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.Validations;
using SimpleHotelIS.BusinessPipelines.Messages;
using SimpleHotelIS.Authorization.Requests;

namespace SimpleHotelIS.BusinessPipelines.Facades
{
    public class DefaultEntityCreate<T, DtoT> : ICreateService<T, DtoT>
        where T: class, new()
        where DtoT: class, new()
    {

        private DTOtoEntity<T, DtoT> conversionHandler;
        private IAuthorizationAction<T> authorizationHandler;
        private IInputValidationAction<T> validationHandler;
        private IBusinessValidationAction<T> businessValidationHandler;

        private IDataCreationAction<T> creationHandler;

        public DefaultEntityCreate
            (IAuthorizationProvider author, IInputValidationProvider input, IBusinessValidationProvider business, IModelStore ims)
        {
            conversionHandler = new DTOtoEntity<T, DtoT>();
            authorizationHandler = new AuthorizationAction<T>(CrudAutorizationActionDesc.Create, author);
            validationHandler = new ValidationAction<T>(input);
            businessValidationHandler = new BusinessValidationAction<T>(business);
            creationHandler = new CreateAction<T>(ims);

            //chain it
            authorizationHandler.OutData +=
                (sender, result) =>
                {
                    if (result.Result == "Ok")
                        conversionHandler.Invoke(sender, new EntityMessage<DtoT> { Entity = ((CreateFromDtoRequest<DtoT>)result.OriginalRequest).Dto });
                    else
                        throw new Exception(result.Result);
                };
            conversionHandler.OutEntity += 
                (sender, args) =>
                {
                    creationHandler.Invoke(sender, new EntityMessage<T> { Entity = args.Entity });
                    ims.SaveChanges();
                };
            //authorizationHandler.OutEntity += (src, args) => { validationHandler.GetTask(src, null); };
            //validationHandler.OutEntity += creationHandler.GetTask;

        }

        public void Invoke(object source, DtoT dto)
        {
            authorizationHandler.Invoke(this, new ResourceRequestMessage( new CreateFromDtoRequest<DtoT> { Dto = dto } ));
        }
    }
}