using System.Threading.Tasks;
using Domain.DTO;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Areas.Identity.Controllers
{
    [Area("Admin")]  
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
        public async Task<IActionResult> Store(CategoryDTO categoryDTO)
        {
            if(!ModelState.IsValid)
            {
                return View("create", categoryDTO);
            }
            await  _categoryService.AddCategory(categoryDTO);
            return RedirectToAction("Index", "Category", new { area = "Admin" });

        }
        // [HttpPost("AddCategory")]
        // public async Task<IActionResult> AddCategory([FromBody]CategoryDTO categoryDTO)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         var category = await  _categoryService.AddCategory(categoryDTO);
        //         return Ok(category);
        //     }

        //     return BadRequest(ModelState.GetModelStateErrors());
        // }

        // [HttpGet("GetCategory")]
        // public async Task<CategoryDTO> GetCategory([BindRequired]int id)
        // {
        //     return await _categoryService.GetCategory(id);
        // }

        // [HttpPost("AddCategory")]
        // public async Task<IActionResult> AddCategory([FromBody]CategoryDTO categoryDTO)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         var category = await  _categoryService.AddCategory(categoryDTO);
        //         return Ok(category);
        //     }

        //     return BadRequest(ModelState.GetModelStateErrors());
        // }

        // [HttpDelete("DeleteCategory")]
        // public async Task<IActionResult> DeleteCategory([BindRequired]int id)
        // {
            
        //     if(ModelState.IsValid)
        //     {
        //         await _categoryService.DeleteCategory(id);
        //         return Ok("Success");
        //     }

        //     return BadRequest(ModelState.GetModelStateErrors());
        // }

        // [HttpPut("UpdateCategory")]
        // public async Task<IActionResult> UpdateCategory([BindRequired]int id,CategoryDTO categoryDTO)
        // {
            
        //     if(ModelState.IsValid)
        //     {
        //         await _categoryService.UpdateCategory(id,categoryDTO);
        //         return Ok("Success");
        //     }

        //     return BadRequest(ModelState.GetModelStateErrors());
        // }
    }
}