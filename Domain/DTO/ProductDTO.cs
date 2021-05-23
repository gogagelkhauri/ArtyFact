using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Domain.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool InStock { get; set; }
        public string Description { get; set; }
        [Required]
        [DisplayFormat( NullDisplayText = "Choose Image" )]    
        public IFormFile ActualImage { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public int UserId { get; set; }
        public CategoryDTO Category { get; set; }
        #nullable enable
        public ProductDetailDTO? ProductDetail { get; set; }
    }
}
