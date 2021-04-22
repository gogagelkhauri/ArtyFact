using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System.Linq;

namespace Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryService(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            var categoryInDb = await _repository.AddAsync(category);
            var categoryDTOFromDb = _mapper.Map<CategoryDTO>(categoryInDb);

            return categoryDTOFromDb;
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(category);
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            var categories = await _repository.ListAsync();
            var categoryDTO = categories.Select(x => new CategoryDTO() {Id = x.Id, Name = x.Name}).ToList();
            
            return categoryDTO;
        }

        public async Task<CategoryDTO> GetCategory(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            var categoryDTO = _mapper.Map<CategoryDTO>(category);
            return categoryDTO;
        }

        public async Task UpdateCategory(int id,CategoryDTO categoryDTO)
        {
            //var category = await _repository.GetByIdAsync(id);
            var category = _mapper.Map<Category>(categoryDTO);
            category.Id = id;
            await _repository.UpdateAsync(category);
        }
    }
}