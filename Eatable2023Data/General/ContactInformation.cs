using Eatable.Common.Enums;
using System;

namespace Eatable.Data.General
{
    public class ContactInformation
    {
        public Guid ContactId { get; set; }

        public ContactInformationType ContactInformationTypeCode { get; set; }

        public string ContactInfo { get; set; }

    }
}
