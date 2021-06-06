using Domain.Entities;
using Domain.Entities.User;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
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
        private readonly IOrderService _orderService;

        public BasketController(
            UserManager<ApplicationUser> userManager,
            IBasketService basketService,
            IOrderService orderService)
        {
            _userManager = userManager;
            _basketService = basketService;
            _orderService = orderService;
        }
        public async Task<IActionResult> Index()
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            var basket = await _basketService.GetOrCreateBasket(user.UserProfile.Id);
            if (basket == null)
                basket = new Domain.Entities.Basket.Basket();

            return View(basket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(int productId)
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            await _basketService.AddToBasket(user.UserProfile.Id, productId);
            return Redirect("/Basket");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(int productId)
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

            await _basketService.RemoveFromBasket(user.UserProfile.Id, productId);
            return Redirect("/Basket");
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Order(Domain.Entities.Order order)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.Users.Include(u => u.UserProfile)
                .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

                await _orderService.CreateOrderAsync(user.UserProfile.Id, order);

            }
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult Processing(string stripeToken, string stripeEmail)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessingPayment(string stripeToken, string stripeEmail)
        {
            int amount = 100;
            Dictionary<string, string> Metadata = new Dictionary<string, string>();
            Metadata.Add("Product", "RubberDuck");
            Metadata.Add("Quantity", "10");
            var options = new ChargeCreateOptions
            {
                Amount = amount,
                Currency = "USD",
                Description = "Buying 10 rubber ducks",
                Source = stripeToken,
                ReceiptEmail = stripeEmail,
                Metadata = Metadata
            };
            var service = new ChargeService();
            Charge charge = service.Create(options);
            return View();
        }
    }
}
