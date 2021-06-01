using Domain.Entities;

namespace Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public float Price { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}