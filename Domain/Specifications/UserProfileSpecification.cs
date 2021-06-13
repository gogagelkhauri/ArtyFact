using Ardalis.Specification;
using Domain.Entities.User;

namespace Domain.Specifications
{
    public sealed class UserWithCategoriesSpecification : Specification<UserProfile>
    {
        public UserWithCategoriesSpecification(int id) 
        {
            Query
                .Where(b => b.Id == id);
              Query.Include(b => b.UserCategories);
        }
    }
}