using System.Threading.Tasks;
using Domain.DTO;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controlles
{
    //[Authorize(Roles = "Admin")]
    public class CategoryController : Controller  
    {  
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetMostSoldCategories();
            return View(categories);
        }
    }
}