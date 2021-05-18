using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.DTO;
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
        public IActionResult Profile(string username)  
        {  
            //var user = await _userManager.FindByNameAsync(username);
            var user = _userProfileService.GetUserProfile(username);
            var viewModel = new UserProfileViewModel
            {
                User = user
                //UserProfile = userProfile
            };
            return View(viewModel);  
        }

        [HttpGet]
        public IActionResult EditProfile(string username)
        {
            //var user = await _userManager.FindByNameAsync(username);
            var profileDTO = _userProfileService.GetUserProfileDTO(username);
            return View(profileDTO);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(UserProfileDTO userProfileDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("/UserAccount/EditProfile?username=" + User.Identity.Name, userProfileDTO);
            }

            await _userProfileService.UpdateUserProfile(userProfileDTO);
          

            return Redirect("/UserAccount/Profile?username=" + User.Identity.Name);
        }



    }  

}