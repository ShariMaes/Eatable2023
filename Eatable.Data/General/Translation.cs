using Eatable.Common.Enum;
using Eatable.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Data.General
{
    public class Translation : Base
    {
        [Key]
        public Guid TranslationId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TranslationIdentifier { get; set; }

        [Required]
        public TranslationType TranslationType { get; set; }

        [Required]
        public ModuleType ModuleType { get; set; }

        [Required]
        public string Nld { get; set; }

        [Required]
        public string Fra { get; set; }

        [Required]
        public string Eng { get; set; }

        [Required]
        public string Deu { get; set; }

        public DateTime? ValidUntil { get; set; }
    }
}
