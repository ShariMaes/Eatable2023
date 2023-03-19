using Eatable.Common.Enum;
using Eatable.Data.Common;
using Eatable.Data.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Data.Store
{
    public class Store : Base
    {
        [Key]
        public Guid StoreId { get; set; }

        [Required]
        [MaxLength(50)]
        public string StoreIdentifier { get; set; }

        [Required]
        [MaxLength(100)]
        public string StoreName { get; set; }

        public Address? Address { get; set; }

        public StoreType StoreType { get; set; }

        public string? OpeningHours { get; set; }

        public List<ContactInformation>? ContactInformation { get; set; }

        [MaxLength(100)]
        public string? StoreUrl { get; set; }

        [MaxLength(100)]
        public string? LogoName { get; set; }
    }
}
