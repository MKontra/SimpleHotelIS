using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Interfaces;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.BusinessPipelines.Actions;
using SimpleHotelIS.BusinessPipelines.Actions.CRUD;
using SimpleHotelIS.BusinessPipelines.Messages;
using SimpleHotelIS.Authorization.Requests;
using System.Threading;
using SimpleHotelIS.DTO;

namespace SimpleHotelIS.BusinessPipelines.Facades
{
    public class DefaultGetById<T, DtoT> : IGetByIdService<T, DtoT>
        where T : class, new()
        where DtoT : class, new()
    {
        private IAuthorizationAction<T> authorizationHandler;
        private IDataAccessAction<T> accessHandler;

        private ManualResetEventSlim resultReady = new ManualResetEventSlim();
        private DtoT result = null;

        public DefaultGetById
            (IAuthorizationProvider author, IModelStore ims)
        {
            authorizationHandler = new AuthorizationAction<T>(CrudAutorizationActionDesc.Read, author);
            accessHandler = new ReadAction<T>(ims);

            //chain it
            authorizationHandler.OutData += 
                (sender, result) => 
                {
                    if (result.Result == "Ok")
                        accessHandler.Invoke(this, new DataMessage { Data = ((ReadByIdRequest)result.OriginalRequest).Id });
                    else
                        throw new Exception(result.Result);
                };
            accessHandler.OutError += (sender, data) => { resultReady.Set(); };
            accessHandler.OutData += 
                (sender, data) => 
                { result = (DtoT) DtoAssembler.toDto<T>(data.Entity); 
                  resultReady.Set();
                };
        }

        public DtoT Invoke(object source, Object id)
        {
            authorizationHandler.Invoke(this, new ResourceRequestMessage(new ReadByIdRequest { Id = id } ));
            resultReady.Wait();
            return result;
        }
    }
}