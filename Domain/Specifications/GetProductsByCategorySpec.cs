using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public sealed class GetProductsByCategorySpec : Specification<Product>
    {
        public GetProductsByCategorySpec(string category)
        {
            Query.Where(o => o.Category.Name == category && o.InStock == true).Include(x => x.Category);
             Query.Include(b => b.User).ThenInclude(u => u.User);
        }
    }
}
