using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class CancelAccountViewModel
    {
        [Required(ErrorMessage = "Password is required")]  
        public string Password { get; set; }  
    
        [Required(ErrorMessage = "Confirm password is required")]  
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]  
        public string ConfirmPassword { get; set; }  
    }
}