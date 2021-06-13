using System.Collections.Generic;
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
using Web.ViewModels;

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
        public async Task<IActionResult> Profile(string username)  
        {  
            //var user = await _userManager.FindByNameAsync(username);
            var user = await _userProfileService.GetUserProfile(username);
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
            var manageCategories = new List<ManageUserCategories>();
            var categoriesDTO = await _categoryService.GetAllCategories();
            foreach(var category in categoriesDTO)
            {
                var manageUserCat = new ManageUserCategories()
                {
                    CategoryId = category.Id,
                    CategoryName = category.Name
                };
                var userCat = profileDTO.UserCategories.Where(x => x.Category.Name == category.Name);
                if(userCat.Count() > 0)
                {
                    manageUserCat.Selected = true;
                }
                else
                {
                    manageUserCat.Selected = false;
                }

                // foreach(var userCat in profileDTO.UserCategories)
                // {
                    
                // }
                manageCategories.Add(manageUserCat);
            }
            var viewModel = new EditProfileViewModel
            {
                UserProfile = profileDTO,
                UserCategories = manageCategories
               // Categories = categoryDTO
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

            await _userProfileService.UpdateUserProfile(viewModel.UserProfile,viewModel.UserCategories);
          

            return Redirect("/UserAccount/Profile?username=" + User.Identity.Name);
        }

        public void Artists()
        {
            var artists = _userManager;
        }


    }  

}