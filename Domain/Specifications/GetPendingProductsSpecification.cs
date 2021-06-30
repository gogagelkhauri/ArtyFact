using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public sealed class GetPendingProductsSpecification : Specification<Product>
    {
        public GetPendingProductsSpecification()
        {
            Query.Where(o => o.Status == false).Include(x => x.Category);
            Query.Include(x => x.User).ThenInclude(u => u.User);
        }
    }
}
