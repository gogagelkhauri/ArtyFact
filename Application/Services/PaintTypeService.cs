using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System.Linq;

namespace Application.Services
{
    public class PaintTypeService : IPaintTypeService
    {
        private readonly IRepository<PaintType> _repository;
        private readonly IMapper _mapper;
        public PaintTypeService(IRepository<PaintType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaintTypeDTO> AddPaintType(PaintTypeDTO paintTypeDTO)
        {
            var paintType = _mapper.Map<PaintType>(paintTypeDTO);
            var paintTypeInDb = await _repository.AddAsync(paintType);
            var paintTypeDTOFromDb = _mapper.Map<PaintTypeDTO>(paintTypeInDb);

            return paintTypeDTOFromDb;
        }

        public async Task DeletePaintType(int id)
        {
            var paintType = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(paintType);
        }

        public async Task<List<PaintTypeDTO>> GetAllPaintTypes()
        {
            var paintTypes = await _repository.ListAsync();
            var paintTypeDTO = paintTypes.Select(x => new PaintTypeDTO() {Id = x.Id, Name = x.Name}).ToList();
            
            return paintTypeDTO;
        }

        public async Task<PaintTypeDTO> GetPaintType(int id)
        {
            var paintType = await _repository.GetByIdAsync(id);
            var paintTypeDTO = _mapper.Map<PaintTypeDTO>(paintType);
            return paintTypeDTO;
        }

        public async Task UpdatePaintType(int id,PaintTypeDTO paintTypeDTO)
        {
            //var category = await _repository.GetByIdAsync(id);
            var paintType = _mapper.Map<PaintType>(paintTypeDTO);
            paintType.Id = id;
            await _repository.UpdateAsync(paintType);
        }
    }
}