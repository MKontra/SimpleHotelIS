using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BusinessPipelines.Interfaces;

namespace SimpleHotelIS.BusinessPipelines
{
    public interface ICrudServiceProvider<T, TDto>
        where T : class, new()
        where TDto : class, new()
    {
        IGetByIdService<T, TDto> CreateIGetByIdService();
        IAsQueryableService<T, TDto> CreateIAsQueryableService();
        IDeleteService<T, TDto> CreateIDeleteService();
        IUpdateService<T, TDto> CreateIUpdateService();
        ICreateService<T, TDto> CreateICreateService();
    }
}
