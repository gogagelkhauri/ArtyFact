using Domain.Entities.User;

namespace Domain.Entities
{
    public class ProductDetail : BaseEntity
    {
        public int ProductId { get; set; } 
        public Product Product { get; set; }
        public string Size { get; set; }
        public int PaintTypeId { get; set; }
        public PaintType PaintType { get; set; }
    }
}