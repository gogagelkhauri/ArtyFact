using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Entities.User;
using Infrastructure.EmailService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Identity.ViewModels;

namespace Web.Areas.Identity.Controllers
{
    [Area("Identity")]  
    public class AccountController : Controller  
    {  
        private readonly UserManager<ApplicationUser> userManager;  
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IEmailSender _emailSender;
        public AccountController(UserManager<ApplicationUser> userManager,  
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender)
        {
            this.userManager = userManager;  
            this.signInManager = signInManager;  
            _emailSender = emailSender;
        }

        [HttpGet]  
        [AllowAnonymous]  
        public IActionResult Login()  
        {   if (User.Identity.IsAuthenticated)
            {   
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            LoginViewModel model = new LoginViewModel();  
            return View(model);  
        }  

        [HttpPost]  
        [AllowAnonymous]  
        public async Task<IActionResult> Login(LoginViewModel model)  
        {  
            if (ModelState.IsValid)  
            {  
                var user = await userManager.FindByEmailAsync(model.Email);  
                // if (user != null && !user.EmailConfirmed)  
                // {  
                //     ModelState.AddModelError("message", "Email not confirmed yet");  
                //     return View(model);  
    
                // }  
                if (await userManager.CheckPasswordAsync(user, model.Password) == false)  
                {  
                    ModelState.AddModelError("Password", "Invalid credentials");  
                    return View(model);  
                }  
    
                var result = await signInManager.PasswordSignInAsync(user.UserName, model.Password,false, false);  
    
                if (result.Succeeded)  
                {  
                    //await userManager.AddClaimAsync(user, new Claim("UserRole", "Admin"));  
                    return RedirectToAction("Index", "Home", new { area = "" });
                }  
                // else if (result.IsLockedOut)  
                // {  
                //     return View("AccountLocked");  
                // }  
                else  
                {  
                    ModelState.AddModelError("message", "Invalid login attempt");  
                    return View(model);  
                }  
            }  
            return View(model);  
        }  

        [HttpPost]
        public async Task<IActionResult> Logout()  
        {  
            await signInManager.SignOutAsync();  
            return RedirectToAction("Index", "Home", new { area = "" });
        } 

        [HttpGet, AllowAnonymous]  
        public IActionResult Register()  
        {  
            if (User.Identity.IsAuthenticated)
            { 
                return RedirectToAction("Index", "Home", new { area = "" });
            }  
            RegisterViewModel model = new RegisterViewModel();  
            return View(model);
            //return "Goga";
        }  

        [HttpPost, AllowAnonymous]  
        public async Task<IActionResult> Register(RegisterViewModel request)  
        {  
            if (ModelState.IsValid)  
            {  
                var userCheck = await userManager.FindByEmailAsync(request.Email);  
                if (userCheck == null)  
                {  
                    var user = new ApplicationUser  
                    {  
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        UserName = request.UserName,  
                        NormalizedUserName = request.UserName,  
                        Email = request.Email,  
                        EmailConfirmed = true,  
                        PhoneNumberConfirmed = true,  
                        UserProfile = new UserProfile(),
                    };  
                    var result = await userManager.CreateAsync(user, request.Password);
                    await userManager.AddToRoleAsync(user, "Default");  
                    if (result.Succeeded)  
                    {  
                        return RedirectToAction("Login");  
                    }  
                    else  
                    {  
                        if (result.Errors.Count() > 0)  
                        {  
                            foreach (var error in result.Errors)  
                            {  
                                ModelState.AddModelError("message", error.Description);  
                            }  
                        }  
                        return View(request);  
                    }  
                }  
                else  
                {  
                    ModelState.AddModelError("Email", "Email already exists.");  
                    return View(request);  
                }  
            }  
            return View(request);  
    
        }  

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            if (User.Identity.IsAuthenticated)
            { 
                return RedirectToAction("Index", "Home", new { area = "" });
            }  

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(forgotPasswordModel);
            var user = await userManager.FindByEmailAsync(forgotPasswordModel.Email);
            if (user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Account", new { token, email = user.Email }, Request.Scheme);
            var message = new Message(new string[] { user.Email }, "Reset password token", callback, null);
            await _emailSender.SendEmailAsync(message);
            return RedirectToAction("ForgotPasswordConfirmation", "Account", new { area = "Identity" });
            //return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }
        public IActionResult ForgotPasswordConfirmation()
        {
            if (User.Identity.IsAuthenticated)
            { 
                return RedirectToAction("Index", "Home", new { area = "" });
            }  
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            if (User.Identity.IsAuthenticated)
            { 
                return RedirectToAction("Index", "Home", new { area = "" });
            }  
            var model = new ResetPasswordViewModel { Token = token, Email = email };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(resetPasswordModel);
            var user = await userManager.FindByEmailAsync(resetPasswordModel.Email);
            if (user == null)
                RedirectToAction(nameof(ResetPasswordConfirmation));
            var resetPassResult = await userManager.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);
            if(!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }
        
        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            if (User.Identity.IsAuthenticated)
            { 
                return RedirectToAction("Index", "Home", new { area = "" });
            }  
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied(string returnUrl = null)
        {
            return Redirect("/Identity/Account/Login");

        }


    }  

}