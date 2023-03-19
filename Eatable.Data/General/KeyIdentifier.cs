using Eatable.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Data.General
{
    public class KeyIdentifier
    {
        [Key]
        public ObjectCodeType ObjectCode { get; set; }
        public int Identifier { get; set; }
    }
}
