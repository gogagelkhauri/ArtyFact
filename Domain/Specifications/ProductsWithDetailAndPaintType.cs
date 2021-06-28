using Ardalis.Specification;
using Domain.Entities;

namespace Domain.Specifications
{
    public sealed class ProductsWithDetailAndPaintType : Specification<Product>
    {
        public ProductsWithDetailAndPaintType() 
        {
            Query.Where(x => x.InStock == true).Include(b => b.Category);
            Query.Include(b => b.User).ThenInclude(u => u.User);
            //Query.Include(X => X.ProductDetail)
            //        .ThenInclude(X => X.PaintType);
        }
    }
}