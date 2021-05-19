using System.Collections.Generic;
using Domain.DTO;

namespace Web.VieModels
{
    public class EditProfileViewModel
    {
        public UserProfileDTO UserProfile { get; set; }
        public List<CategoryDTO> Categories { get; set; }
    }
}