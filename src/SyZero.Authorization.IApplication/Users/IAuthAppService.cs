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
        [Get("GetVerificationCode")]
        Task<bool> GetVerificationCode(string phone);

        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Post("Login")]
        Task<string> Login(LoginDto input);

        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Post("Register")]
        Task<bool> Register(CreateUserDto input);

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        [Post("LogOut")]
        Task<bool> LogOut();

    
    }
}



