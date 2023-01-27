using Eatable.Data.General;
using System;

namespace Eatable.Data.Product
{
    public class Store: Base
    {
        public Guid StoreId { get; set; }

        public string StoreIdentifier { get; set; }

        public string StoreName { get; set; }

        public Address Address { get; set; }

        public string StoreType { get; set; }

        public string OpeningHours { get; set; }
    }
}
