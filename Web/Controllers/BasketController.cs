using Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class BasketController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public BasketController(
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
                                       .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            return View();
        }
    }
}
