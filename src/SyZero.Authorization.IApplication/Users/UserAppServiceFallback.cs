﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyZero.Application.Service.Dto;
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

        public Task<UserDto> Get(long input)
        {
            throw new NotImplementedException();
        }

        public Task<PageResultDto<UserDto>> List(PageAndSortQueryDto input)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Create(CreateUserDto input)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Update(long id, UserDto input)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Update(long id, CreateUserDto input)
        {
            throw new NotImplementedException();
        }
    }
}
