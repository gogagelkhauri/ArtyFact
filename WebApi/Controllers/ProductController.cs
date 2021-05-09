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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProducts")]
        public async Task<List<ProductDTO>> GetProducts()
        {
            return await _productService.GetAllproducts();
        }

        [HttpGet("GetProduct")]
        public async Task<ProductDTO> GetCategory([BindRequired]int id)
        {
            return await _productService.GetProduct(id);
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct([FromBody]ProductDTO productDTO)
        {
            if(ModelState.IsValid)
            {
                var category = await  _productService.AddProduct(productDTO);
                return Ok(productDTO);
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct([BindRequired]int id)
        {
            
            if(ModelState.IsValid)
            {
                await _productService.DeleteProduct(id);
                return Ok("Success");
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([BindRequired]int id,ProductDTO productDTO)
        {
            
            if(ModelState.IsValid)
            {
                await _productService.UpdateProduct(id,productDTO);
                return Ok("Success");
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }
    }
}