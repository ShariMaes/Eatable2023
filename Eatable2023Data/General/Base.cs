using System;
using System.ComponentModel.DataAnnotations;

namespace Eatable.Data.General
{
    public class Base
    {
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedBy { get; set; }
    }
}
