using System.Threading.Tasks;
using Domain.DTO;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controlles
{
    [Area("Admin")]  
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
            var categories = await _categoryService.GetAllCategories();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Store(CategoryDTO categoryDTO)
        {
            var existingCategory = await _categoryService.GetCategoryByName(categoryDTO.Name);
            if(!ModelState.IsValid || existingCategory != null)
            {
                return View("create", categoryDTO);
            }
            await  _categoryService.AddCategory(categoryDTO);
            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var existingCategory = await _categoryService.GetCategory(id);
            if(ModelState.IsValid  || existingCategory == null)
            {
                await _categoryService.DeleteCategory(id);
            }

            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetCategory(id);
            if(category != null)
                return View(category);
            return RedirectToAction("Index", "Category", new { area = "Admin" });
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CategoryDTO categoryDTO)
        {
            var existingCategory = await _categoryService.GetCategory(categoryDTO.Id);
            if (!ModelState.IsValid)
            {
                return View("edit", categoryDTO);
            }

            await _categoryService.UpdateCategory(categoryDTO.Id,categoryDTO);
            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }
    }
}