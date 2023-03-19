using Eatable.Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eatable.Dto.User
{
    public  class RightDto
    {
        public Guid RightId { get; set; }

        public ObjectCodeType ObjectCodeType { get; set; }

        public bool Read { get; set; } = false;

        public bool Write { get; set; } = false;

        public bool Edit { get; set; } = false;

        public bool Delete { get; set; } = false;
    }
}
