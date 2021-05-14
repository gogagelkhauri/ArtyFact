using System.ComponentModel.DataAnnotations;

namespace Web.Areas.Identity.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}