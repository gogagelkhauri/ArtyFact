using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.DTO;
using Microsoft.AspNetCore.Http;
using Web.Attrubute;

namespace Web.ViewModels
{
    public class EditProductViewModel
    {
        public List<CategoryDTO> Categories { get; set; }
        public ProductDTO Product { get; set; }

        [DisplayFormat( NullDisplayText = "Choose Image" )]
        //[Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" }, ErrorMessage = "Your image's filetype is not valid.")]
        public IFormFile ActualImage { get; set; }
    }
}