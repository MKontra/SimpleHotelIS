using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased
{
    public interface IActionTask<TArg1>
    {
        Task GetTask(TArg1 arg1);
    }

    public interface IFuncTask<TResult>
    {
        Task<TResult> GetTask();
    }

    public interface IFuncTask<TResult, TArg1>
    {
        Task<TResult> GetTask(TArg1 arg1);
    }

    public interface IFuncTask<TResult, TArg1, TArg2>
    {
        Task<TResult> GetTask(TArg1 arg1, TArg2 arg2);
    }
}
