using Domain.Entities.User;

namespace Domain.Entities
{

    public class UserCategory : BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string UserId { get; set; }
        public UserProfile User { get; set; }
    }

}