using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.User;

namespace Domain.DTO
{
    public class UserProfileDTO
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Gender { get; set; }
        public string FacebookURL { get; set; }
        public string InstagramURL { get; set; }
        public string WorkDescription { get; set; }
        public List<UserCategoryDTO> UserCategories { get; set; }
        //public string UserId { get; set; }
    }
}