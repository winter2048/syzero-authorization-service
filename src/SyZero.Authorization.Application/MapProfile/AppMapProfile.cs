using AutoMapper;
using SyZero.Authorization.Core.Users;
using SyZero.Authorization.IApplication.Users.Dto;

namespace SyZero.Authorization.Application.MapProfile
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<User, CreateUserDto>();
            CreateMap<CreateUserDto, User>();

            
        }
    }
}