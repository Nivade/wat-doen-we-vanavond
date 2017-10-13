using System.ComponentModel.DataAnnotations;

namespace Vanavond.Models.View
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
