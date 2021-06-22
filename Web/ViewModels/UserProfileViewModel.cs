using Domain.DTO;
using Domain.Entities.User;

namespace Web.ViewModels
{
    public class UserProfileViewModel
    {
        //public UserProfileDTO UserProfile { get; set; }
        public ApplicationUser User { get; set; }
        public ApplicationUser AuthUser { get; set; }
    }
}