using Eatable.Common.Enum;
using Eatable.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Data.General
{
    public class Address : Base
    {
        [Key]
        public Guid AddressId { get; set; }

        [MaxLength(250)]
        public string? Street { get; set; }

        [Required]
        public CountryCodeType CountryCode { get; set; }

        [MaxLength(10)]
        public string? HouseNumber { get; set; }

        [MaxLength(10)]
        public string? BoxNumber { get; set; }

        [Required]
        [MaxLength(10)]
        public string Postalcode { get; set; }

        [MaxLength(250)]
        public string? City { get; set; }
    }
}
