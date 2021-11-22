using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using SyZero.Application.Attributes;
using SyZero.Application.Routing;
using SyZero.Authorization.IApplication.Users.Dto;
using SyZero.Web.Common;

namespace SyZero.Authorization.IApplication.Users
{
    public interface IAuthAppService : IApplicationServiceBase
    {
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        Task<bool> GetVerificationCode(string phone);

        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [ApiMethod(HttpMethod.POST)]
        Task<string> Login(LoginDto input);

        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [ApiMethod(HttpMethod.POST)]
        Task<bool> Register(CreateUserDto input);

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        [ApiMethod(HttpMethod.POST)]
        Task<bool> LogOut();

        /// <summary>
        /// 获取登录人信息
        /// </summary>
        /// <returns></returns>
        [ApiMethod(HttpMethod.GET)]
        Task<UserDto> GetUserInfo();

        /// <summary>
        /// 修改登录人信息
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [ApiMethod(HttpMethod.PUT)]
        Task<bool> PutUserInfo(CreateUserDto dto);
    
    }
}



