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
    }
}