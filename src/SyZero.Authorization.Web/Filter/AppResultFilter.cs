using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SyZero.Authorization.Web.Core.Models;

namespace SyZero.Authorization.Web.Core.Filter
{
    /// <summary>
    /// 异常过滤器
    /// </summary>
    public class AppResultFilter : IResultFilter, IOrderedFilter
    {
        public int Order { get; set; } = int.MaxValue - 10;


        public void OnResultExecuted(ResultExecutedContext context)
        {
            // context.Result 
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result.GetType() == typeof(ObjectResult))
            {
                context.Result = new JsonResult(new ResultModel((context.Result as ObjectResult)?.Value));
            }
        }
    }



}



