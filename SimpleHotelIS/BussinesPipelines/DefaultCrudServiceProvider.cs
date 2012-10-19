using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BussinesPipelines.Facades;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.Repositories;

namespace SimpleHotelIS.BussinesPipelines
{
    public class DefaultCrudServiceProvider : ICrudServiceProvider
    {

        private IAuthorizationProvider author;
        private IValidationProvider validator;
        private IModelStore ims;

        public DefaultCrudServiceProvider(IAuthorizationProvider author, IValidationProvider validator, IModelStore ims)
        {
            this.author = author;
            this.validator = validator;
            this.ims = ims;
        }

        public Interfaces.IGetByIdService<T, TDto> GetByIdService<T, TDto>() where T: class, new() where TDto: class, new()
        {
            throw new NotImplementedException();
        }

        public Interfaces.IAsQueryableService<T, TDto> GetAsQueryableService<T, TDto>() where T: class, new() where TDto: class, new()
        {
            throw new NotImplementedException();
        }

        public Interfaces.IDeleteService<T, TDto> GetDeleteService<T, TDto>() where T: class, new() where TDto: class, new()
        {
            throw new NotImplementedException();
        }

        public Interfaces.IUpdateService<T, TDto> GetUpdateService<T, TDto>() where T: class, new() where TDto: class, new()
        {
            throw new NotImplementedException();
        }

        public Interfaces.ICreateService<T, TDto> GetCreateService<T, TDto>() where T: class, new() where TDto: class, new()
        {
            return new DefaultEntityCreate<T, TDto>(author, validator, ims);
        }
    }
}