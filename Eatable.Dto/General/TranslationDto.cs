using Eatable.Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eatable.Dto.General
{
    public class TranslationDto
    {
        public Guid TranslationId { get; set; }

        public string TranslationIdentifier { get; set; }

        public TranslationType TranslationType { get; set; }

        public ModuleType ModuleType { get; set; }

        public string Nld { get; set; }

        public string Fra { get; set; }

        public string Eng { get; set; }

        public string Deu { get; set; }

        public DateTime? ValidUntil { get; set; }
    }
}
