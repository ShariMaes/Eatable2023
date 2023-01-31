using System;

namespace Eatable.Data.General
{
    public class Base
    {
        public DateTime Created { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedBy { get; set; }
    }
}
