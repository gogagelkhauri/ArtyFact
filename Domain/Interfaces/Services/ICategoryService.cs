using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO);
        Task<CategoryDTO> GetCategory(int id);
        Task<CategoryDTO> GetCategoryByName(string name);
        Task<List<CategoryDTO>> GetAllCategories();
        Task UpdateCategory(int id,CategoryDTO categoryDTO);
        Task DeleteCategory(int id);
        Task<List<Category>> GetMostSoldCategories();
    }
}