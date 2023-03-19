using Eatable.Dto.Store;
using Eatable.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.UserManager
{
    public interface IUserManager
    {
        Task<UserDto> AddOrUpdateUser(UserDto userdto);
        Task<UserDto> GetUserById(Guid id);
        Task<UserDto> GetUserByIdentifier(string identifier);
        Task<List<UserDto>> GetUserList();
    }
}
