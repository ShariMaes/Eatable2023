using Eatable.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Dto.General
{
    public class ContactInformationDto
    {
        public Guid ContactId { get; set; }

        public Guid ObjectId { get; set; }

        public ContactInformationType ContactInformationTypeCode { get; set; }

        public string ContactInfo { get; set; }
    }
}
