using SyZero.Application.Attributes;
using SyZero.Application.Service;

namespace SyZero.Authorization.IApplication
{
    [DynamicWebApi]
    public interface IApplicationServiceBase : IApplicationService, IDynamicWebApi
    {
    }
}



