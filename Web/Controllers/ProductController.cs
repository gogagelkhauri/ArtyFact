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
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductController(IProductService productService,
        ICategoryService categoryService,
        IPaintTypeService paintTypeService,
        UserManager<ApplicationUser> userManager
        )
        {
          _productService = productService;
          _categoryService = categoryService;
          _paintTypeService = paintTypeService;
          _userManager = userManager;
        }

        [HttpGet]  
        public IActionResult Products()  
        {  
            //var user = await _userManager.FindByNameAsync(username);
            var product = _productService.GetAllproducts().Result;
            
            return View(product);  
        }

        public async Task<IActionResult> Product(int id)
        {
            if(id > 0)
            {
                var product = await _productService.GetProduct(id);

                if (product != null)
                    return Redirect("/Product/Products");

                return View(product);
            }

            return Redirect("/Product/Products");
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
                Product = new ProductDTO(),
                Categories = categories,
                PaintTypes = paintTypes
            };
            
            return View(viewModel);  
        }

        [HttpPost]
        public async Task<IActionResult> Store(AddProductViewModel viewModel)
        {
            viewModel.Product.UserId = _userManager.GetUserAsync(HttpContext.User).Id;
            if (ModelState.IsValid)
            {
                await _productService.AddProduct(viewModel.Product);
                return Redirect("/Product/Products");
            }
            return View("/Product", viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {

            if (ModelState.IsValid && id != 0)
            {
                await _productService.DeleteProduct(id);
            }

            return RedirectToAction("Products", "Product");
        }




    }  

}