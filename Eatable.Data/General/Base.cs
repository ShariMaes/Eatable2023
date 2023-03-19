using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Data.Common
{
    public class Base
    {
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        [AllowNull]
        public string? CreatedBy { get; set; } = string.Empty;

        [AllowNull]
        public DateTime? Modified { get; set; } = DateTime.Now;

        [AllowNull]
        public string? ModifiedBy { get; set; }
    }
}
