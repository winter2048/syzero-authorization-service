using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyZero.Application.Routing;
using SyZero.Authorization.IApplication.Users.Dto;

namespace SyZero.Authorization.IApplication.Users
{
    public interface IUserAppService : IApplicationServiceBase
    {

        /// <summary>
        /// 获取登录人信息
        /// </summary>
        /// <returns></returns>
        [ApiMethod(HttpMethod.GET, "UserInfo")]
        Task<UserDto> GetUserInfo();

        /// <summary>
        /// 修改登录人信息
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [ApiMethod(HttpMethod.PUT, "UserInfo")]
        Task<bool> PutUserInfo(CreateUserDto dto);

        [ApiMethod(HttpMethod.GET, "GetUser")]
        Task<UserDto> GetUser(long id);
    }
}
