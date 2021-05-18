using Domain.Entities.User;

namespace Domain.DTO
{
    public class UserCategoryDTO
    {
        public CategoryDTO Category { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }
    }

}