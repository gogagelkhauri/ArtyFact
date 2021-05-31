using Ardalis.Specification;
using Domain.Entities.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public sealed class GetBasketItemByProductSpecification : Specification<BasketItem>
    {
        public GetBasketItemByProductSpecification(int productId,int basketId)
        {
            Query.Where(x => x.ProductId == productId);
            Query.Where(x => x.BasketId == basketId);
        }
    }
}