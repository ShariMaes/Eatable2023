using Eatable.Common.Enums;
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

        public StoreType StoreType { get; set; }

        public string OpeningHours { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public string StoreUrl { get; set; }

        public string LogoName { get; set; }
    }
}
