using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public class GetPostWithUserSpecification : Specification<Post>
    {
        public GetPostWithUserSpecification(int id)
        {
            Query.Where(p => p.Id == id).Include(p => p.User).ThenInclude(u => u.User);
        }
    }
}
