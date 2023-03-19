using Eatable.Common.Enum;
using Eatable.Data.Common;
using Eatable.Data.General;
using System.ComponentModel.DataAnnotations;

namespace Eatable.Data.User
{
    public class User : Base
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserIdentifer { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public LanguageCodeType LanguageCode { get; set; }

        public List<ContactInformation>? ContactInformation { get; set; }

        public Address? Address { get; set; }
    }
}
