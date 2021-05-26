using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class ProductDetailDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required]
        public string Size { get; set; }
        public int PaintTypeId { get; set; }
        public PaintTypeDTO PaintType { get; set; }
    }
}
