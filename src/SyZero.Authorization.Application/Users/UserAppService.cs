using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyZero.Application.Service;
using SyZero.Application.Service.Dto;
using SyZero.Authorization.Core.Users;
using SyZero.Authorization.IApplication.Users;
using SyZero.Authorization.IApplication.Users.Dto;
using SyZero.Authorization.Repository;
using SyZero.Cache;
using SyZero.Runtime.Security;
using SyZero.Runtime.Session;
using SyZero.Serialization;
using SyZero.Web.Common;

namespace SyZero.Authorization.Application.Users
{
    public class UserAppService : AsyncCrudAppService<User, UserDto, PageAndSortQueryDto, CreateUserDto>, IUserAppService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICache _cache;
        private readonly ISyEncode _syEncode;
        private readonly IToken _token;
        private readonly IJsonSerialize _jsonSerialize;
        private readonly ISySession _sySeeion;

        public UserAppService(IUserRepository userRepository,
           ICache cache,
           ISyEncode syEncode,
           IToken token,
           IJsonSerialize jsonSerialize,
           ISySession sySeeion) : base(userRepository)
        {
            _userRepository = userRepository;
            _cache = cache;
            _syEncode = syEncode;
            _token = token;
            _jsonSerialize = jsonSerialize;
            _sySeeion = sySeeion;
        }

        public async Task<UserDto> GetUserInfo()
        {
            CheckPermission("");
            var user = await _userRepository.GetModelAsync(p => (p.Id == SySession.UserId));
            return ObjectMapper.Map<UserDto>(user);
        }

        public async Task<bool> PutUserInfo(CreateUserDto dto)
        {
            CheckPermission("");
            var user = await _userRepository.GetModelAsync(p => p.Id == SySession.UserId.Value);

            user = ObjectMapper.Map(dto, user);

            if (!String.IsNullOrEmpty(dto.NewPassword))
            {
                user.Password = _syEncode.Get32MD5One(dto.NewPassword);
            }
            await _userRepository.UpdateAsync(user);
            return true;
        }

        public async Task<UserDto> GetUser(long id)
        {
            var user = await _userRepository.GetModelAsync(p => (p.Id == id));
            return ObjectMapper.Map<UserDto>(user);
        }
    }
}
