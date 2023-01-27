using Eatable.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Dto.Product
{
    public class StoreDto
    {
        public Guid StoreId { get; set; }

        public string StoreIdentifier { get; set; }

        public string StoreName { get; set; }
        
        public AddressDto Address { get; set; }
     
        public string StoreType { get; set; }

        public string OpeningHours { get; set; }
}
}
