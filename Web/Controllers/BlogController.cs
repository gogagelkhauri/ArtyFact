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

namespace WebControllers
{
    public class BlogController : Controller
    {
        private readonly IPostService _postService;
        public BlogController(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _postService.GetPosts();
            return View(posts);
        }

        public async Task<IActionResult> Post(int id)
        {                        
            if (id > 0)
            {
                var post = await _postService.GetPostWithUser(id);

                if (post == null)
                    return Redirect("/Admin/Post");


                return View(post);
            }

            return Redirect("/Admin/Post");
        }
    }
}