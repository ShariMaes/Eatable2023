using Eatable.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Eatable.Data.General
{
    public class ContactInformation
    {
        [Key]
        public Guid ContactId { get; set; }

        public Guid ObjectId { get; set; }

        public ContactInformationType ContactInformationTypeCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string ContactInfo { get; set; }

    }
}
