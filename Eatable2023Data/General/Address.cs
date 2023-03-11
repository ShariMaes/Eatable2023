using System;
using System.ComponentModel.DataAnnotations;

namespace Eatable.Data.General
{
    public class Address: Base
    {
        [Key]
        public Guid AddressId { get; set; }

        public string Street { get; set; }

        public string CountryCode { get; set; }

        public string HouseNumber { get; set; }

        public string BoxNumber { get; set; }

        [Required]
        [MaxLength(10)]
        public string Postalcode { get; set; }

        public string City { get; set; }
    }
}
