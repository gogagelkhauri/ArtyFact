using Domain.Entities;

namespace Domain.Entities.Basket
{
    public class BasketItem : BaseEntity
    {
        public decimal Price { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}