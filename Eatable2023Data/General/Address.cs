using System;

namespace Eatable.Data.General
{
    public class Address: Base
    {
        public Guid AddressId { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int Postalcode { get; set; }

        public string City { get; set; }
    }
}
