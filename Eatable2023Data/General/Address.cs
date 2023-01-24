using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable2023Data.General
{
    public class Address
    {
        public Guid AddressId { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int Postalcode { get; set; }

        public string City { get; set; }
    }
}
