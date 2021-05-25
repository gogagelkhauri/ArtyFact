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
        [Required]
        public string Name { get; set; }
        public bool InStock { get; set; }
        [Required]
        public string Description { get; set; }
        //[Required]
        [DisplayFormat( NullDisplayText = "Choose Image" )]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile ActualImage { get; set; }
        public string ImageURL { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public float Price { get; set; }
        public int UserId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        #nullable enable
        public ProductDetailDTO? ProductDetail { get; set; }
    }
}
