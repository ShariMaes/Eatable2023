using Eatable.Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eatable.Dto.User
{
    public  class RoleDto
    {
        public Guid RoleId { get; set; }
        public UserRoleType RoleType { get; set; }
        public List<RightDto> Rights { get; set; }
    }
}
