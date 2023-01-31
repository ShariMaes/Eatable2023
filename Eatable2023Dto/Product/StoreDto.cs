using Eatable.Common.Enums;
using Eatable.Dto.General;
using System;

namespace Eatable.Dto.Product
{
    public class StoreDto
    {
        public Guid StoreId { get; set; }

        public string StoreIdentifier { get; set; }

        public string StoreName { get; set; }
        
        public AddressDto Address { get; set; }
     
        public StoreType StoreType { get; set; }

        public string OpeningHours { get; set; }

        public ContactInformationDto ContactInformation { get; set; }
    }
}
