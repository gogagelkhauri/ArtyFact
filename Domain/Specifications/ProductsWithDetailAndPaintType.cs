using Ardalis.Specification;
using Domain.Entities;

namespace Domain.Specifications
{
    public sealed class ProductsWithDetailAndPaintType : Specification<Product>
    {
        public ProductsWithDetailAndPaintType() 
        {
            Query.Include(b => b.Category);
            //Query.Include(X => X.ProductDetail)
            //        .ThenInclude(X => X.PaintType);
        }
    }
}