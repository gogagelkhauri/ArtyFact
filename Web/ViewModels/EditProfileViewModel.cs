using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.DTO;

namespace Web.ViewModels
{
    public class EditProfileViewModel
    {
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(70)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username Name name is required")]
        [StringLength(30)]
        public string UserName { get; set; }
        public UserProfileDTO UserProfile { get; set; }
        public List<CategoryDTO> Categories { get; set; }
        public List<ManageUserCategories> UserCategories { get; set; }
    }
}