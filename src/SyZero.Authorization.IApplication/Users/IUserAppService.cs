using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyZero.Application.Routing;
using SyZero.Application.Service.Dto;
using SyZero.Application.Service;
using SyZero.Authorization.IApplication.Users.Dto;

namespace SyZero.Authorization.IApplication.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, PageAndSortQueryDto, CreateUserDto>, IApplicationServiceBase
    {
        /// <summary>
        /// 获取登录人信息
        /// </summary>
        /// <returns></returns>
        [Get("UserInfo")]
        Task<UserDto> GetUserInfo();

        /// <summary>
        /// 修改登录人信息
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [Put("UserInfo")]
        Task<bool> PutUserInfo(CreateUserDto dto);

        [Get("GetUser")]
        Task<UserDto> GetUser(long id);
    }
}
