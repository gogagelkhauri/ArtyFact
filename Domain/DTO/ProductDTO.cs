using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entities.User;
using Microsoft.AspNetCore.Http;
using Shared.Validations;

namespace Domain.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool Status { get; set; }

        public bool InStock { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        
        // [DisplayFormat( NullDisplayText = "Choose Image" )]
        // [Required(ErrorMessage = "Pick an Image")]
        // #pragma warning disable 0436
        // [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" }, ErrorMessage = "Your image's filetype is not valid.")]
        //public IFormFile ActualImage { get; set; }
        public string ImageURL { get; set; }

        [Range(1, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        //[Required]
        public float Price { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        [Required(ErrorMessage = "Pick an Category")]
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        private IFormFile _actualImage;

        public IFormFile GetActualImage()
        {
            return _actualImage;
        }

        public void SetActualImage(IFormFile image)
        {
           _actualImage = image;
        }
        
    }
}
