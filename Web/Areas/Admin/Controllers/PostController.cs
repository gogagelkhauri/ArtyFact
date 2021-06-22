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
using Web.Areas.Admin.ViewModels;
using Web.Helpers;
using Web.ViewModels;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]  
    [Authorize(Roles = "Admin")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<ApplicationUser> _userManager;
        public PostController(IPostService postService,UserManager<ApplicationUser> userManager)
        {
            _postService = postService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _postService.GetPosts();
            return View(posts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Store(AddPostViewModel viewModel)
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
                                        .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            viewModel.Product.UserId = user.UserProfile.Id;
            if (ModelState.IsValid)
            {
                viewModel.Product.SetActualImage(viewModel.ActualImage);
                try
                {
                    await _productService.AddProduct(viewModel.Product);
                    return Redirect("/UserAccount/Profile?userName=" + user.UserName);
                }
                catch(Exception)
                {
                    return Redirect("/Admin/Post");
                }
            }
            return View("/Create", viewModel);
        }
    }
}