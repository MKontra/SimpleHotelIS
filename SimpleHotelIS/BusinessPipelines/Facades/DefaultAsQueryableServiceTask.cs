using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;
using SimpleHotelIS.BusinessPipelines.Actions.TaskBased;
using SimpleHotelIS.Repositories;
using SimpleHotelIS.Authorization;
using System.Threading.Tasks;
using SimpleHotelIS.Authorization.Requests;
using SimpleHotelIS.DTO;

namespace SimpleHotelIS.BusinessPipelines.Facades
{
    public class DefaultAsQueryableServiceTask<T, TDto> : IAsQueryableServiceTask<T, TDto>
        where T : class, new()
        where TDto : class, IEntityConvertible<T, TDto>, new()
    {

        private IModelStore ims;

        public DefaultAsQueryableServiceTask(IModelStore ims)
        {
            this.ims = ims;
        }

        public Task<IQueryable<TDto>> GetTask()
        {
            return new Task<IQueryable<TDto>>(
                () =>
                { return (IQueryable<TDto>)ims.Repository<T>().getQueryable().ToList().Select<T, TDto>(e => (TDto)DtoAssembler.toDto<T>(e)).ToList().AsQueryable(); }
                );
        }
    }
}