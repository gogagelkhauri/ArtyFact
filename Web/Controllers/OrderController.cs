using Domain.Entities;
using Domain.Entities.User;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helpers;
using Web.ViewModels;

namespace Web.Controllers
{
    [Authorize]
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

        
        [HttpGet]
        public async Task<IActionResult> CustomerInformation()
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            var basket = await _basketService.GetOrCreateBasket(user.UserProfile.Id);
            if(basket == null || basket.BasketItems.Count < 1)
            {
                return Redirect("/Basket");
            }
            var viewModel = new CustomerInformationViewModel() {Basket = basket};
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> MyOrders()
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
                    .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            var orders = await _orderService.GetMyOrders(user.UserProfile.Id);
            var viewModel = new MyOrdersViewModel
            {
                Order = orders
             };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomerInformation(CustomerInformationViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                SessionHelper.SetObjectAsJson(HttpContext.Session, "CustomerInfo", viewModel);

                //var user = _userManager.Users.Include(u => u.UserProfile)
                //.SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

                //await _orderService.CreateOrderAsync(user.UserProfile.Id, order);
                return Redirect("/Order/Processing");
            }
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult Processing()
        {
            var customerInfo = SessionHelper.GetObjectFromJson<CustomerInformationViewModel>(HttpContext.Session, "CustomerInfo");
            if(customerInfo != null)
            {
                var viewModel = new ProcessingViewModel();
                viewModel.PublicKey =_config.GetValue<string>("Stripe:PublicKey");
                return View(viewModel);
            }
            return Redirect("/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProcessingPayment(string stripeEmail,string stripeToken)
        {
            var customerInfo = SessionHelper.GetObjectFromJson<CustomerInformationViewModel>(HttpContext.Session, "CustomerInfo");
            if (customerInfo != null)
            {
                var user = _userManager.Users.Include(u => u.UserProfile)
                    .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

                var basket = await _basketService.GetOrCreateBasket(user.UserProfile.Id);
                float total = 0;
                Dictionary<string, string> Metadata = new Dictionary<string, string>();

                for(int i = 0; i < basket.BasketItems.Count; i++)
                {
                    total += basket.BasketItems[i].Price;
                    Metadata.Add("Product " + i, "Name :"+ basket.BasketItems[i].Product.Name + " Price: " + basket.BasketItems[i].Price.ToString());
                }

                //int amount = 100;
                //Metadata.Add("Quantity", "10");
                var options = new ChargeCreateOptions
                {
                    Amount = Convert.ToInt64(total * 100),
                    Currency = "USD",
                    Description = "Buying Products From Artyfact",
                    Source = stripeToken,
                    ReceiptEmail = stripeEmail,
                    Metadata = Metadata
                };
                var service = new ChargeService();
                Charge charge = service.Create(options);

                var order = new Domain.Entities.Order
                {
                    UserId = user.UserProfile.Id,
                    Address = customerInfo.Address,
                    PostCode = Convert.ToInt32(customerInfo.PostCode),
                    City = customerInfo.City,
                    Phone = customerInfo.Phone
                };
                var status = charge.Status;
               
                await _orderService.CreateOrderAsync(user.UserProfile.Id, order);

                SessionHelper.Remove(HttpContext.Session, "CustomerInfo");
            }
            return Redirect("/");
        }
    }
}
