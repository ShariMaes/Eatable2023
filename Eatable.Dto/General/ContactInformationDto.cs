using Eatable.Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

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
