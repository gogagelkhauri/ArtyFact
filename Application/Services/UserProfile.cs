using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.User;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Identity;

namespace Application.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> _profileRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserProfileService(IRepository<UserProfile> profileRepository,
        UserManager<ApplicationUser> userManager)
        {
            _profileRepository = profileRepository;
            _userManager = userManager;
        }

        public async Task AddUserProfile(string userEmail, UserProfile userProfile)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userEmail);
            userProfile.User = user;

            await _profileRepository.AddAsync(userProfile);
        }

        public UserProfile GetUserProfile(string userEmail)
        {
            var userProfile = _userManager.Users.SingleOrDefault(u => u.UserName == userEmail).UserProfile;
            return userProfile;
        }
    }
}