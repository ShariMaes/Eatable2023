using Eatable.Common.Enums;
using Eatable.Data.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eatable.Data.Product
{
    public class Store: Base
    {
        [Key]
        public Guid StoreId { get; set; }

        [Required]
        [MaxLength(50)]
        public string StoreIdentifier { get; set; }

        [Required]
        [MaxLength(100)]
        public string StoreName { get; set; }

        public Address Address { get; set; }

        public StoreType StoreType { get; set; }

        public string OpeningHours { get; set; }

        public List<ContactInformation> ContactInformation { get; set; }

        [MaxLength(100)]
        public string StoreUrl { get; set; }

        [MaxLength(100)]
        public string LogoName { get; set; }
    }
}
