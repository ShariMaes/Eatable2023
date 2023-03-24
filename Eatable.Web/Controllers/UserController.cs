using Eatable.Application.StoreManager;
using Eatable.Application.UserManager;
using Eatable.Dto.Store;
using Eatable.Dto.User;
using Microsoft.AspNetCore.Mvc;

namespace Eatable.Web.Controllers
{

    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [Route("getUserList")]
        [Produces("application/json")]
        public async Task<List<UserDto>> GetUserList()
        {
            var result = await _userManager.GetUserList();
            return result;
        }

        [HttpGet]
        [Route("getUserByIdentifier")]
        [Produces("application/json")]
        public async Task<UserDto> GetUserByIdentifier(string identifier)
        {
            var result = await _userManager.GetUserByIdentifier(identifier);
            return result;
        }

    }

}
