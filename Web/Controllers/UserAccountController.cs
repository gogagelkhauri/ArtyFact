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
using Microsoft.EntityFrameworkCore;
using Web.Areas.Identity.ViewModels;
using Web.ViewModels;

namespace Web.Controllers
{
    [Authorize]
    public class UserAccountController : Controller  
    {  
        private readonly IUserProfileService _userProfileService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICategoryService _categoryService;
         private readonly IBasketService _basketService;
         private readonly IOrderService _orderService;
        public UserAccountController(IUserProfileService userProfileService,
         ICategoryService categoryService,
         UserManager<ApplicationUser> userManager,
         SignInManager<ApplicationUser> signInManager,
         IBasketService basketService,
         IOrderService orderService)
        {
            _userProfileService = userProfileService;
            _userManager = userManager;
            _categoryService = categoryService;
            _signInManager = signInManager;
            _basketService = basketService;
            _orderService = orderService;
        }

        [HttpGet]  
        [AllowAnonymous]
        public async Task<IActionResult> Profile(string username)  
        {  
            //var user = await _userManager.FindByNameAsync(username);
            var user = await _userProfileService.GetUserProfile(username);
            if(user != null)
            {
                var Autuser = _userManager.Users.Include(u => u.UserProfile)
                        .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
                if(Autuser == null)
                {
                    Autuser = new ApplicationUser(){UserName = ""};
                }
                var viewModel = new UserProfileViewModel
                {
                    User = user,
                    AuthUser = Autuser
                    //UserProfile = userProfile
                };
                return View(viewModel);  
            }
            return Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
                    .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            //var user = await _userManager.FindByNameAsync(username);
            var profileDTO = _userProfileService.GetUserProfileDTO(user.UserName);
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
                return View("EditProfile", viewModel);
            }
            var user = _userManager.Users.Include(u => u.UserProfile)
                    .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            viewModel.UserProfile.Id = user.UserProfile.Id;
            await _userProfileService.UpdateUserProfile(viewModel.UserProfile,viewModel.UserCategories);
          

            return Redirect("/UserAccount/Profile?username=" + User.Identity.Name);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Artists()
        {
            var artists = await _userProfileService.GetAllProfile();
            return View(artists);
        }

        [HttpGet]
        public IActionResult Cancel()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancel(CancelAccountViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);  
            }
            var user = _userManager.Users.Include(u => u.UserProfile)
                    .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

            if (await _userManager.CheckPasswordAsync(user, model.Password) == false)  
            {  
                ModelState.AddModelError("Password", "Incorrect Password");  
                return View(model);  
            }  

            await _basketService.DeleteBasket(user.UserProfile.Id);
            await _orderService.DeleteOrders(user.UserProfile.Id);
            IdentityResult result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                await _signInManager.SignOutAsync();  
                return Redirect("/Identity/Account/Login");
            }

            
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);  
            }
            var user = _userManager.Users.Include(u => u.UserProfile)
                    .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

            if (await _userManager.CheckPasswordAsync(user, model.OldPassword) == false)  
            {  
                ModelState.AddModelError("Password", "Incorrect Password");  
                return View(model);  
            }  

            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,model.NewPassword);
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("Password", "Failed To Change Password");  
                return View(model);
            }
            return Redirect("/UserAccount/ChangePassword/");
        }

    }  

}