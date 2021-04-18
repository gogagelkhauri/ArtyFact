using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO);
        Task<CategoryDTO> GetCategory(int id);
        Task<List<CategoryDTO>> GetAllCategories();
        Task UpdateCategory(int id,CategoryDTO categoryDTO);
        Task DeleteCategory(int id);
    }
}