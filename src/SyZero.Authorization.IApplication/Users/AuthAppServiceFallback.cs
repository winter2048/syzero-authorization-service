using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SyZero.Authorization.IApplication.Users.Dto;
using SyZero.Cache;
using SyZero.Client;
using SyZero.Runtime.Security;
using SyZero.Serialization;
using SyZero.Web.Common;

namespace SyZero.Authorization.IApplication.Users
{
    public class AuthAppServiceFallback : IAuthAppService, IFallback
    {
        private readonly ILogger<AuthAppServiceFallback> _logger;

        public AuthAppServiceFallback(ILogger<AuthAppServiceFallback> logger)
        {
            _logger = logger;
        }

        public Task<bool> GetVerificationCode(string phone)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(LoginDto input)
        {
            _logger.LogError("Fallback => AuthAppService:Login");
            return null;
        }

        public Task<bool> LogOut()
        {
            _logger.LogError("Fallback => AuthAppService:LogOut");
            return null;
        }

        public Task<bool> Register(CreateUserDto input)
        {
            _logger.LogError("Fallback => AuthAppService:Register");
            return null;
        }
    }
}
