using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Shared.Validations;

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
        
        [DisplayFormat( NullDisplayText = "Choose Image" )]
        [Required(ErrorMessage = "Pick an Image")]
        #pragma warning disable 0436
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile ActualImage { get; set; }
        public string ImageURL { get; set; }

        [Range(1, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        //[Required]
        public float Price { get; set; }
        public int UserId { get; set; }
        [Required(ErrorMessage = "Pick an Category")]
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        #nullable enable
        public ProductDetailDTO? ProductDetail { get; set; }
    }
}
