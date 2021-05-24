using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public sealed class GetCategoryByName : Specification<Category>
    {
        public GetCategoryByName(string name)
        {
            Query.Where(p => p.Name == name);
        }
    }
}
