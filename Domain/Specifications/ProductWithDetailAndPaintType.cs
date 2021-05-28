using Ardalis.Specification;
using Domain.Entities;

namespace Domain.Specifications
{
    public sealed class ProductWithDetailAndPaintType : Specification<Product>
    {
        public ProductWithDetailAndPaintType(int id) 
        {
            Query
            .Where(b => b.Id == id)
            .Include(b => b.Category);

            //Query.Include(X => X.ProductDetail)
            //        .ThenInclude(X => X.PaintType);
        }
    }
}