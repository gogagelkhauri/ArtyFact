using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels
{
    public class UserViewModel
    {
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(70)]
        public string Email { get; set; }

        [Range(1, 1000000000, ErrorMessage = "Value must be between 9 digits")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Username Name name is required")]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}