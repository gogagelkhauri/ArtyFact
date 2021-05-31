using Ardalis.Specification;
using Domain.Entities.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public sealed class GetUsersBasketWithItems : Specification<Basket>
    {
        public GetUsersBasketWithItems(int userId)
        {
            Query.Where(p => p.UserId == userId)
            .Include(x => x.BasketItems)
            .ThenInclude(x => x.Product);
        }
    }
}