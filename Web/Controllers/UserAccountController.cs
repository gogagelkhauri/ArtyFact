using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Entities.User;
using Domain.Interfaces.Services;
using Infrastructure.EmailService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Identity.ViewModels;
using Web.VieModels;

namespace Web.Controllers
{
    [Authorize]
    public class UserAccountController : Controller  
    {  
        private readonly IUserProfileService _userProfileService;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserAccountController(IUserProfileService userProfileService,
        UserManager<ApplicationUser> userManager
        )
        {
           _userProfileService = userProfileService;
           _userManager = userManager;

        }

        [HttpGet]  
        public async Task<IActionResult> Profile(string email)  
        {  
            var user = await _userManager.FindByEmailAsync(email);
            var userProfile = _userProfileService.GetUserProfile(email);
            var viewModel = new UserProfileViewModel
            {
                User = user,
                UserProfile = userProfile
            };
            return View(viewModel);  
        }  
    }  

}