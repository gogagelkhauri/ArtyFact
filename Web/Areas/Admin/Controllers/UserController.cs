using Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Admin.ViewModels;

namespace Web.Areas.Admin.Controlles
{
    [Area("Admin")]  
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private IPasswordHasher<ApplicationUser> passwordHasher;


        public UserController(UserManager<ApplicationUser> usrMgr, IPasswordHasher<ApplicationUser> passwordHash)
        {
            userManager = usrMgr;
            passwordHasher = passwordHash;
        }


        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appUser = new ApplicationUser
                {
                    UserName = user.UserName,
                    EmailConfirmed = true,
                    PhoneNumber = user.PhoneNumber.ToString(),
                    Email = user.Email
                };

                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
                await userManager.AddToRoleAsync(appUser, "Default");
                if (result.Succeeded)
                    return Redirect("/Admin/UserRoles");
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }

        public async Task<IActionResult> Update(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
            else
                return Redirect("/Admin/UserRoles");
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, string email, string password)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                if (!string.IsNullOrEmpty(password))
                    user.PasswordHash = passwordHasher.HashPassword(user, password);
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return Redirect("/Admin/UserRoles");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return Redirect("/Admin/UserRoles");
                else
                    //    Errors(result);
                    BadRequest();
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return Redirect("/Admin/UserRoles");
        }
    
    }
}