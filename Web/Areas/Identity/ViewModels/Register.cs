using System.ComponentModel.DataAnnotations;

namespace Web.Areas.Identity.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First name is required")]  
        [StringLength(30)]  
        public string FirstName { get; set; }   

        [Required(ErrorMessage = "Last Name name is required")]  
        [StringLength(30)]  
        public string LastName { get; set; }   

        [Required(ErrorMessage = "Username Name name is required")]  
        [StringLength(30)]  
        public string UserName { get; set; }  
            
        [EmailAddress(ErrorMessage = "Invalid email address")]  
        [Required(ErrorMessage = "Email is required")]  
        [StringLength(70)]  
        public string Email { get; set; } 

        [Required(ErrorMessage = "Password is required")]  
        public string Password { get; set; }  
    
        [Required(ErrorMessage = "Confirm password is required")]  
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]  
        public string ConfirmPassword { get; set; }  
    }
}