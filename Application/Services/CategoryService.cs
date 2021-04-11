using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Interfaces.Services;

namespace Aplication.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteCategory(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Task<CategoryDTO>> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryDTO> GetCategory(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryDTO> UpdateCategory(CategoryDTO categoryDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}