using System;

namespace Eatable.Data.General
{
    public class Address: Base
    {
        public Guid AddressId { get; set; }

        public string Street { get; set; }

        public string CountryCode { get; set; }

        public string HouseNumber { get; set; }

        public string BoxNumber { get; set; }

        public string Postalcode { get; set; }

        public string City { get; set; }
    }
}
