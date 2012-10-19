using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleHotelIS.BussinesPipelines.Interfaces;

namespace SimpleHotelIS.BussinesPipelines
{
    public interface ICrudServiceProvider
    {
        IGetByIdService<T, TDto> GetByIdService<T, TDto>()
            where T : class, new()
            where TDto : class, new();

        IAsQueryableService<T, TDto> GetAsQueryableService<T, TDto>()
            where T : class, new()
            where TDto : class, new();

        IDeleteService<T, TDto> GetDeleteService<T, TDto>()
            where T : class, new()
            where TDto : class, new();

        IUpdateService<T, TDto> GetUpdateService<T, TDto>()
            where T : class, new()
            where TDto : class, new();

        ICreateService<T, TDto> GetCreateService<T, TDto>()
            where T : class, new()
            where TDto : class, new();
    }
}
