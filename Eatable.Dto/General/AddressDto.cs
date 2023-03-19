using System;
using System.Collections.Generic;
using System.Text;

namespace Eatable.Dto.General
{
    public class AddressDto
    {
        public Guid AddressId { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string Postalcode { get; set; }

        public string City { get; set; }
    }
}
