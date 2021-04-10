using System.Collections.Generic;
using Domain.Entities.User;

namespace Domain.Entities
{
    public class PaintType : BaseEntity
    {
        public string Name { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
    }
}