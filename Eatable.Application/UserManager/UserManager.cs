using AutoMapper;
using Eatable.Application.General;
using Eatable.Common.Enum;
using Eatable.Data.Store;
using Eatable.Data.User;
using Eatable.Dto.Store;
using Eatable.Dto.User;
using Eatable.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.UserManager
{
    public class UserManager : BaseManager, IUserManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IKeyIdentifierManager _keyIdentifierManager;

        public UserManager(EatableContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, IKeyIdentifierManager keyIdentifierManager) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _keyIdentifierManager = keyIdentifierManager;
        }

        public async Task<UserDto> AddOrUpdateUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            if (user.UserIdentifer.IsNullOrEmpty())
            {
                var keyIdentifer = await _keyIdentifierManager.GetNextKeyIdentifierByObjectCodeType(ObjectCodeType.User);

                user.UserIdentifer = keyIdentifer;
                user.UserId = new Guid();
                user.Role = GetRoleWithRights(user.Role.RoleType).Result;


                _context.Add(user);
                _context.SaveChanges();
            }
            else
            {
                //Get + Update
                //await _context.SaveChangesAsync();
            }

            return GetUserByIdentifier(user.UserIdentifer).Result;
        }

        public async Task<UserDto> GetUserByIdentifier(string identifier)
        {
            var store = await _context.User
                 .Include(u => u.ContactInformation)
                 .Include(u => u.Address)
                 .SingleAsync(u => u.UserIdentifer.Equals(identifier));

            var mapped = _mapper.Map<UserDto>(store);

            return mapped;
        }

        public async Task<UserDto> GetUserById(Guid id)
        {
            var store = await _context.User
                 .Include(u => u.ContactInformation)
                 .Include(u => u.Address)
                 .SingleAsync(u => u.UserId.Equals(id));

            var mapped = _mapper.Map<UserDto>(store);

            return mapped;
        }

        public async Task<Role> GetRoleWithRights(UserRoleType roleType)
        {
            var role = await _context.Role
                .Include(s => s.Rights)
                .SingleOrDefaultAsync(s => s.RoleType == roleType);

            role ??= await _context.Role
               .Include(s => s.Rights)
               .SingleAsync(s => s.RoleType == UserRoleType.Basic);

            var mapped = _mapper.Map<Role>(role);

            return mapped;
        }

        public async Task<List<UserDto>> GetUserList()
        {
            throw new NotImplementedException();
        }
    }
}
