using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities.User
{
    public class UserProfile : BaseEntity
    {
        public string Image { get; set; }
        public string Gender { get; set; }
        public string FacebookURL { get; set; }
        public string InstagramURL { get; set; }
        public string WorkDescription { get; set; }
        public List<UserCategory> UserCategories { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public List<Product> Products { get; set; }
        public List<Post> Posts { get; set; }
        public List<Order> Orders { get; set; }
    }
}