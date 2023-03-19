using Eatable.Common.Enum;
using System.ComponentModel.DataAnnotations;

namespace Eatable.Data.User
{
    public class Right
    {
        [Key]
        public Guid RightId { get; set; }

        [Required]
        public ObjectCodeType ObjectCodeType { get; set; }

        [Required]
        public bool Read { get; set; } = false;

        [Required]
        public bool Write { get; set; } = false;

        [Required]
        public bool Edit { get; set; } = false;

        [Required]
        public bool Delete { get; set; } = false;
    }
}
