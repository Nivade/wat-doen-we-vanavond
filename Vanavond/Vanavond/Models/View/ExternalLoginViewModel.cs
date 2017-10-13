using System.ComponentModel.DataAnnotations;

namespace Vanavond.Models.View
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string GivenName { get; set; }
        public string Surname { get; set; }

        [RegularExpression(@"[A-z\s]*")]
        public string Nickname { get; set; }
    }
}
