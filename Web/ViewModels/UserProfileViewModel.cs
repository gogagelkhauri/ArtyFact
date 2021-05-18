using Domain.DTO;
using Domain.Entities.User;

namespace Web.VieModels
{
    public class UserProfileViewModel
    {
        //public UserProfileDTO UserProfile { get; set; }
        public ApplicationUser User { get; set; }
    }
}