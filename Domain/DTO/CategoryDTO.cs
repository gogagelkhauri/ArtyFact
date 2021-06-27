using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Domain.DTO
{
    public class CategoryDTO 
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ImageURL { get; set; }

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