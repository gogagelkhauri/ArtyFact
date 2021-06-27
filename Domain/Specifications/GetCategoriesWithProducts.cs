using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public sealed class GetCategoriesWithProducts : Specification<Category>
    {
        public GetCategoriesWithProducts()
        {
            Query.Include(c => c.Products);
        }
    }
}
