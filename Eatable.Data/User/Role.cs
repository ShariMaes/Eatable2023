using Eatable.Common.Enum;
using Eatable.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Data.User
{
    public class Role
    {
        [Key]
        public Guid RoleId { get; set; }

        [Required]
        public UserRoleType RoleType { get; set; }

        [Required]
        public List<Right> Rights { get; set;}

    }
}
