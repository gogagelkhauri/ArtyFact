using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities.User;
using Domain.Interfaces.Services;
using Infrastructure.EmailService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Identity.ViewModels;
using Web.ViewModels;

namespace Web.Controllers
{
    [Authorize]
    public class ProductController : Controller  
    {  
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IPaintTypeService _paintTypeService;
        public ProductController(IProductService productService,
        ICategoryService categoryService,
        IPaintTypeService paintTypeService
        )
        {
          _productService = productService;
          _categoryService = categoryService;
          _paintTypeService = paintTypeService;
        }

        [HttpGet]  
        public IActionResult Products()  
        {  
            //var user = await _userManager.FindByNameAsync(username);
            var product = _productService.GetAllproducts().Result;
            
            return View(product);  
        }

        [HttpGet]  
        public async Task<IActionResult> AddProduct()  
        {  
            //var user = await _userManager.FindByNameAsync(username);
            var categories = await  _categoryService.GetAllCategories();
            var paintTypes = await  _paintTypeService.GetAllPaintTypes();
            //var productDTO = 
            var viewModel = new AddProductViewModel
            {
                Categories = categories,
                PaintTypes = paintTypes
            };
            
            return View(viewModel);  
        }

        [HttpPost]
        public async Task<IActionResult> Store(AddProductViewModel viewModel)
        {
            viewModel.Categories = new List<CategoryDTO>();
            viewModel.Product.UserId = 9;
            if (ModelState.IsValid)
            {
                await _productService.AddProduct(viewModel.Product);
                return Redirect("/Product/Products");
            }
            return View("/Products", viewModel);

        }


    }  

}