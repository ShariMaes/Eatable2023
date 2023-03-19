using AutoMapper;
using Eatable.Data.User;
using Eatable.Dto.User;

namespace Eatable.Application.Automapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<RoleDto, Role>();
            CreateMap<RightDto, Right>();

            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<Right, RightDto>();
        }
    }
}
