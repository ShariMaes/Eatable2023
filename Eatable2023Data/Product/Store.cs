using Eatable2023Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable2023Data.Product
{
    public class Store
    {
        public Guid StoreId { get; set; }

        public string StoreIdentifier { get; set; }

        public string StoreName { get; set; }

        public Address Address { get; set; }

        public string StoreType { get; set; }

        public string OpeningHours { get; set; }
    }
}
