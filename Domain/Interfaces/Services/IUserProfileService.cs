using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.User;

namespace Domain.Interfaces.Services
{
    public interface IUserProfileService
    {
        //Task<CategoryDTO> AddCategory(CategoryDTO categoryDTO);
        UserProfileDTO GetUserProfileDTO(string userEmail);
        ApplicationUser GetUserProfile(string userEmail);
        Task UpdateUserProfile(UserProfileDTO userProfile);
        //void UpdateUserProfile(string userEmail,UserProfileDTO userProfile);
        //Task<List<CategoryDTO>> GetAllCategories();
        //Task UpdateCategory(int id,CategoryDTO categoryDTO);
        //Task DeleteCategory(int id);
    }
}