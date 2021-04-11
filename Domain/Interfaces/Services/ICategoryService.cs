using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTOs;

namespace Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO);
        Task<CategoryDTO> GetCategory(int id);
        List<Task<CategoryDTO>> GetAllCategories();
        Task<CategoryDTO> UpdateCategory(CategoryDTO categoryDTO);
        Task DeleteCategory(int id);
    }
}