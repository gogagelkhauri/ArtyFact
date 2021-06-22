using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.User;

namespace Domain.Entities.Basket
{
    public class Basket : BaseEntity
    {
        //public string BuyerId { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public List<BasketItem> BasketItems { get; set; }

        public float GetTotal()
        {
            var total = 0f;
            foreach(var item in BasketItems)
            {
                total += item.Product.Price;
            }
            return total;

        }
    }
}