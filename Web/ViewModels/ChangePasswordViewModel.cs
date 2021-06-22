using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Password is required")] 
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Password is required")] 
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm password is required")]  
        [Compare("NewPassword", ErrorMessage = "The NewPassword and Confirm Password do not match.")]  
        public string ConfirmPassword { get; set; }
    }
}