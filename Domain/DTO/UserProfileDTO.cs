using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using Domain.Entities.User;
using Microsoft.AspNetCore.Http;
using Shared.Validations;

namespace Domain.DTO
{
    public class UserProfileDTO
    {
        public int Id { get; set; }
        [DisplayFormat( NullDisplayText = "Choose Image" )]
        // [Required(ErrorMessage = "Pick an Image")]
        // #pragma warning disable 0436
        // [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile ActualImage { get; set; }
        public string Image { get; set; }
        //[Required]
        public string Gender { get; set; }
        //[Required]
        public string FacebookURL { get; set; }
        //[Required]
        public string InstagramURL { get; set; }
        //[Required]
        public string WorkDescription { get; set; }
        public List<UserCategoryDTO> UserCategories { get; set; }
        //public string UserId { get; set; }
    }
}