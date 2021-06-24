using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManageProductsController : Controller
    {
        private readonly IProductService _productService;
        public ManageProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _productService.GetPendingPosts();
            return View(posts);
        }

        public async Task<IActionResult> Approve(int id)
        {
            if(id != 0)
                await _productService.Approve(id);

                return Redirect("/Admin/ManageProducts");
        }
    }
}
