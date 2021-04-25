using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApi.Helpers;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetCategories")]
        public async Task<List<CategoryDTO>> GetCategories()
        {
            return await _categoryService.GetAllCategories();
        }

        [HttpGet("GetCategory")]
        public async Task<CategoryDTO> GetCategory([BindRequired]int id)
        {
            return await _categoryService.GetCategory(id);
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromBody]CategoryDTO categoryDTO)
        {
            if(ModelState.IsValid)
            {
                var category = await  _categoryService.AddCategory(categoryDTO);
                return Ok(category);
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([BindRequired]int id)
        {
            
            if(ModelState.IsValid)
            {
                await _categoryService.DeleteCategory(id);
                return Ok("Success");
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([BindRequired]int id,CategoryDTO categoryDTO)
        {
            
            if(ModelState.IsValid)
            {
                await _categoryService.UpdateCategory(id,categoryDTO);
                return Ok("Success");
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }
    }
}