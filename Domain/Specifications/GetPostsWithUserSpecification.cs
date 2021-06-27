using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public class GetPostsWithUserSpecification : Specification<Post>
    {
        public GetPostsWithUserSpecification()
        {
            Query.Include(p => p.User).ThenInclude(u => u.User);
        }
    }
}
