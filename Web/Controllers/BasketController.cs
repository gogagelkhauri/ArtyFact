using Domain.Entities.User;
using Domain.Interfaces.Services;
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
        private readonly IBasketService _basketService;

        public BasketController(
            UserManager<ApplicationUser> userManager,
            IBasketService basketService
            )
        {
            _userManager = userManager;
            _basketService = basketService;
        }
        public async Task<IActionResult> Index()
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            var basket = await _basketService.GetOrCreateBasket(user.UserProfile.Id);

            return View(basket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(int productId)
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            await _basketService.AddToBasket(user.UserProfile.Id,productId);
            return Redirect("/Basket");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(int productId)
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            
            await _basketService.RemoveFromBasket(user.UserProfile.Id,productId);
            return Redirect("/Basket");
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
