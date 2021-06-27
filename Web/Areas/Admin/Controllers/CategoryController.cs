using System.Threading.Tasks;
using Domain.DTO;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Admin.ViewModels;

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

            var viewModel = new AddCategoryViewModel
            {
               Category = new Domain.DTO.CategoryDTO()
            };

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Store(AddCategoryViewModel viewModel)
        {
            var existingCategory = await _categoryService.GetCategoryByName(viewModel.Category.Name);
            if(!ModelState.IsValid || existingCategory != null)
            {
                return View("create", viewModel);
            }
            viewModel.Category.SetActualImage(viewModel.ActualImage);
            await  _categoryService.AddCategory(viewModel.Category);
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
            if (id > 0)
            {
                var category = await _categoryService.GetCategory(id);
                if(category != null)
                    return View(new EditCategoryViewModel(){Category = category});
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }
            return Redirect("/Admin/Category");
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EditCategoryViewModel viewModel)
        {
            var existingCategory = await _categoryService.GetCategory(viewModel.Category.Id);
            if (!ModelState.IsValid)
            {
                return View("edit", viewModel);
            }

            if (viewModel.ActualImage != null)
            {
                viewModel.Category.SetActualImage(viewModel.ActualImage);
            }

            await _categoryService.UpdateCategory(viewModel.Category.Id,viewModel.Category);
            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }
    }
}