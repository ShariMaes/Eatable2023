using Eatable.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Eatable.Data.General
{
    public class Translation: Base
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
        public string Fr { get; set; }

        [Required]
        public string Eng { get; set; }

        [Required]
        public string Deu { get; set; }
    }
}
