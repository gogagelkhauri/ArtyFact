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
        public IActionResult AddPost()
        {
            var viewModel = new AddPostViewModel
            {
               Post = new Domain.DTO.PostDTO()
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Store(AddPostViewModel viewModel)
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
                                        .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            viewModel.Post.UserId = user.UserProfile.Id;
            if (ModelState.IsValid)
            {
                viewModel.Post.SetActualImage(viewModel.ActualImage);
                try
                {
                    await _postService.Create(viewModel.Post);
                    return Redirect("/Admin/Post");
                }
                catch(Exception)
                {
                    return Redirect("/Admin/Post");
                }
            }
            return View("/Create", viewModel);
        }

        public async Task<IActionResult> EditPost(int id)
        {
            //var user = _userManager.Users.Include(u => u.UserProfile)
            //                           .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            if (id > 0)
            {
                var post = await _postService.GetPost(id);

                if (post == null)
                    return Redirect("/Admin/Post");

                var viewModel = new EditPostViewModel
                {
                    Post = post
                };


                return View(viewModel);
            }

            return Redirect("/Admin/Post");
        }

        [HttpPost]
        public async Task<IActionResult> Update(EditPostViewModel viewModel)
        {
            
            if (!ModelState.IsValid)
            {
                //bad
                return View("EditPost", viewModel);
            }

            if (viewModel.ActualImage != null)
            {
                viewModel.Post.SetActualImage(viewModel.ActualImage);
            }
            try
            {
                await _postService.Update(viewModel.Post.Id, viewModel.Post);
                return Redirect("/Admin/Post");
            }
            catch (Exception)
            {
                return Redirect("/Admin/Post");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            //var user = _userManager.Users.Include(u => u.UserProfile)
            //                            .SingleOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            if (ModelState.IsValid && id != 0)
            {
                await _postService.Delete(id);
            }

            return Redirect("/Admin/Post");
        }
    }
}