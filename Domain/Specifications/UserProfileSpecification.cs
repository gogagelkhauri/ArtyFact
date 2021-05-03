using Ardalis.Specification;
using Domain.Entities.User;

namespace Domain.Specifications
{
    public sealed class BasketWithItemsSpecification : Specification<UserProfile>
    {
        public BasketWithItemsSpecification(int id) 
        {
            Query
                .Where(b => b.Id == id)
                .Include(b => b.UserCategories);
        }
    }
}