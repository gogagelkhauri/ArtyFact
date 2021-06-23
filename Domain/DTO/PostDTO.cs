using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entities.User;
using Microsoft.AspNetCore.Http;

namespace Domain.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }

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