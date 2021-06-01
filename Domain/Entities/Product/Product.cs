using System.Collections.Generic;
using Domain.Entities.Basket;
using Domain.Entities.User;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public bool InStock { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}