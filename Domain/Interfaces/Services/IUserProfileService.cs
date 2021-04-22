using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;
using Domain.Entities.User;

namespace Domain.Interfaces.Services
{
    public interface IUserProfileService
    {
        //Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO);
        UserProfile GetUserProfile(string userEmail);
        Task AddUserProfile(string userEmail,UserProfile userProfile);
        //Task<List<CategoryDTO>> GetAllCategories();
        //Task UpdateCategory(int id,CategoryDTO categoryDTO);
        //Task DeleteCategory(int id);
    }
}