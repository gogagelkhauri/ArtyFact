using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public sealed class GetOrderByUserId : Specification<Order>
    {
        public GetOrderByUserId(int userId)
        {
            Query.Where(o => o.UserId == userId).Include(x => x.OrderItems).ThenInclude(i => i.Product);
        }
    }
}
