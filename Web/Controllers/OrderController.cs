using Domain.Entities;
using Domain.Entities.User;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IConfiguration _config;
        
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IBasketService _basketService;
        private readonly IOrderService _orderService;

        public OrderController(
            UserManager<ApplicationUser> userManager,
            IBasketService basketService,
            IOrderService orderService,
            IConfiguration config)
        {
            _userManager = userManager;
            _basketService = basketService;
            _orderService = orderService;
            _config = config;
        }
        public string Index()
        {
            return "works";
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
        public IActionResult Processing()
        {
            var viewModel = new ProcessingViewModel();
           // var publicKey =_config.GetSection("Stripe").GetSection("PublicKey");
            viewModel.PublicKey =_config.GetValue<string>("Stripe:PublicKey");
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Processing1()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ProcessingPayment( string stripeEmail,string stripeToken)
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
            return Redirect("/");
        }
    }
}
