using System.Threading.Tasks;
using Domain.DTO;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controlles
{
    [Area("Admin")]  
    public class PaintTypeController : Controller  
    {  
        private readonly IPaintTypeService _paintTypeService;
        public PaintTypeController(IPaintTypeService paintTypeService)
        {
            _paintTypeService = paintTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var paintTypes = await _paintTypeService.GetAllPaintTypes();
            return View(paintTypes);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Store(PaintTypeDTO paintTypeDTO)
        {
            if(!ModelState.IsValid)
            {
                return View("create", paintTypeDTO);
            }
            await  _paintTypeService.AddPaintType(paintTypeDTO);
            return RedirectToAction("Index", "PaintType", new { area = "Admin" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            
            if(ModelState.IsValid)
            {
                await _paintTypeService.DeletePaintType(id);
            }

            return RedirectToAction("Index", "PaintType", new { area = "Admin" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            var paintType = await _paintTypeService.GetPaintType(id);
            if(paintType != null)
                return View(paintType);
            return RedirectToAction("Index", "PaintType", new { area = "Admin" });
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(PaintTypeDTO paintTypeDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("edit", paintTypeDTO);
            }

            await _paintTypeService.UpdatePaintType(paintTypeDTO.Id,paintTypeDTO);
            return RedirectToAction("Index", "PaintType", new { area = "Admin" });
            

            //return BadRequest(ModelState.GetModelStateErrors());
        }
    }
}