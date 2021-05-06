using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO);
        Task<CategoryDTO> GetCategory(int id);
        Task<List<CategoryDTO>> GetAllCategories();
        Task UpdateCategory(int id,CategoryDTO categoryDTO);
        Task DeleteCategory(int id);
    }
}