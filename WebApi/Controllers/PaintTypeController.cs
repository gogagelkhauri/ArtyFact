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
    public class PaindTypeController : ControllerBase
    {
        private readonly IPaintTypeService _paintTypeService;
        public PaindTypeController(IPaintTypeService paintTypeService)
        {
            _paintTypeService = paintTypeService;
        }

        [HttpGet("GetPaintTypes")]
        public async Task<List<PaintTypeDTO>> GetPaintTypes()
        {
            return await _paintTypeService.GetAllPaintTypes();
        }

        [HttpGet("GetPaintType")]
        public async Task<PaintTypeDTO> GetCategory([BindRequired]int id)
        {
            return await _paintTypeService.GetPaintType(id);
        }

        [HttpPost("AddPaintType")]
        public async Task<IActionResult> AddPaintType([FromBody]PaintTypeDTO paintTypeDTO)
        {
            if(ModelState.IsValid)
            {
                var paintType = await  _paintTypeService.AddPaintType(paintTypeDTO);
                return Ok(paintType);
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([BindRequired]int id)
        {
            
            if(ModelState.IsValid)
            {
                await _paintTypeService.DeletePaintType(id);
                return Ok("Success");
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpPut("UpdatePaintType")]
        public async Task<IActionResult> UpdatePaintType([BindRequired]int id,PaintTypeDTO paintTypeDTO)
        {
            
            if(ModelState.IsValid)
            {
                await _paintTypeService.UpdatePaintType(id,paintTypeDTO);
                return Ok("Success");
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }
    }
}