using System.Collections.Generic;
using Domain.DTO;

namespace Web.ViewModels
{
    public class AddProductViewModel
    {
        public List<CategoryDTO> Categories { get; set; }
        public List<PaintTypeDTO> PaintTypes { get; set; }
        public ProductDTO Product { get; set; }
    }
}