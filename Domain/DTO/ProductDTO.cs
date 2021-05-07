using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool InStock { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        #nullable enable
        public ProductDetailDTO? ProductDetail { get; set; }
    }
}
