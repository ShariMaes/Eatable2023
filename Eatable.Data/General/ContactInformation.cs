using Eatable.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
