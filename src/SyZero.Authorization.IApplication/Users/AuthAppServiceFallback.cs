using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SyZero.Authorization.IApplication.Users.Dto;
using SyZero.Cache;
using SyZero.Client;
using SyZero.Logger;
using SyZero.Runtime.Security;
using SyZero.Serialization;
using SyZero.Web.Common;

namespace SyZero.Authorization.IApplication.Users
{
    public class AuthAppServiceFallback : IAuthAppService, IFallback
    {
        private readonly ILogger _logger;

        public AuthAppServiceFallback(ILogger logger)
        {
            _logger = logger;
        }

        public Task<bool> GetVerificationCode(string phone)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(LoginDto input)
        {
            _logger.Error("Fallback => AuthAppService:Login");
            return null;
        }

        public Task<bool> LogOut()
        {
            _logger.Error("Fallback => AuthAppService:LogOut");
            return null;
        }

        public Task<bool> Register(CreateUserDto input)
        {
            _logger.Error("Fallback => AuthAppService:Register");
            return null;
        }
    }
}
