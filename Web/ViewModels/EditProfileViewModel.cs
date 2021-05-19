using System.Collections.Generic;
using Domain.DTO;

namespace Web.ViewModels
{
    public class EditProfileViewModel
    {
        public UserProfileDTO UserProfile { get; set; }
        public List<CategoryDTO> Categories { get; set; }
        public List<ManageUserCategories> UserCategories { get; set; }
    }
}