using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyZero.Authorization.IApplication.Users.Dto;
using SyZero.Client;
using SyZero.Logger;

namespace SyZero.Authorization.IApplication.Users
{
    public class UserAppServiceFallback : IUserAppService, IFallback
    {
        private readonly ILogger _logger;

        public UserAppServiceFallback(ILogger logger)
        {
            _logger = logger;
        }

        public Task<bool> PutUserInfo(CreateUserDto dto)
        {
            _logger.Error("Fallback => AuthAppService:PutUserInfo");
            return null;
        }

        public Task<UserDto> GetUserInfo()
        {
            _logger.Error("Fallback => AuthAppService:GetUserInfo");
            return null;
        }

        public Task<UserDto> GetUser(long id)
        {
            throw new NotImplementedException();
        }
    }
}
