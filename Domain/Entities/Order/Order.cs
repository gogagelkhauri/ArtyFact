using System.Collections.Generic;
using Domain.Entities.User;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}