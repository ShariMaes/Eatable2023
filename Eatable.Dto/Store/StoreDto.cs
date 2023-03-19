using Eatable.Common.Enum;
using Eatable.Dto.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eatable.Dto.Store
{
    public class StoreDto
    {
        public Guid StoreId { get; set; }

        public string StoreIdentifier { get; set; }

        public string StoreName { get; set; }

        public AddressDto Address { get; set; }

        public StoreType StoreType { get; set; }

        public string OpeningHours { get; set; }

        public List<ContactInformationDto> ContactInformation { get; set; }

        public string StoreUrl { get; set; }

        public string LogoName { get; set; }
    }
}
