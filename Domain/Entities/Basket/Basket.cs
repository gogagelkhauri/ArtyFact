using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities.Basket
{
    public class Basket : BaseEntity
    {
        public string BuyerId { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}