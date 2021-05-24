using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IPaintTypeService
    {
        Task<PaintTypeDTO> AddPaintType(PaintTypeDTO paintTypeDTO);
        Task<PaintTypeDTO> GetPaintType(int id);
        Task<PaintTypeDTO> GetPaintTypeByName(string name);
        Task<List<PaintTypeDTO>> GetAllPaintTypes();
        Task UpdatePaintType(int id,PaintTypeDTO paintTypeDTO);
        Task DeletePaintType(int id);
    }
}