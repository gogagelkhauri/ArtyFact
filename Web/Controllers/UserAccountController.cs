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
        private readonly ICategoryService _categoryService;
        public UserAccountController(IUserProfileService userProfileService,
        ICategoryService categoryService,
        UserManager<ApplicationUser> userManager
        )
        {
           _userProfileService = userProfileService;
           _userManager = userManager;
           _categoryService = categoryService;

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
        public async Task<IActionResult> EditProfile(string username)
        {
            //var user = await _userManager.FindByNameAsync(username);
            var profileDTO = _userProfileService.GetUserProfileDTO(username);
            var categoryDTO = await _categoryService.GetAllCategories();
            var viewModel = new EditProfileViewModel
            {
                UserProfile = profileDTO,
                Categories = categoryDTO
            };


            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(EditProfileViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("/UserAccount/EditProfile?username=" + User.Identity.Name, viewModel);
            }

            await _userProfileService.UpdateUserProfile(viewModel.UserProfile);
          

            return Redirect("/UserAccount/Profile?username=" + User.Identity.Name);
        }



    }  

}