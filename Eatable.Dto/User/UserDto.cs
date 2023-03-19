using Eatable.Common.Enum;
using Eatable.Dto.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Eatable.Dto.User
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string UserIdentifer { get; set; }
        public RoleDto Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LanguageCodeType LanguageCode { get; set; }
        public List<ContactInformationDto> ContactInformation { get; set; }
        public AddressDto Address { get; set; }
    }
}
}
