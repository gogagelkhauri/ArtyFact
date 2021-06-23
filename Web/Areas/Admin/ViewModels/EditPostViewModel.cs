using Domain.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Attrubute;

namespace Web.Areas.Admin.ViewModels
{
    public class EditPostViewModel
    {
        public PostDTO Post { get; set; }

        [DisplayFormat(NullDisplayText = "Choose Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" }, ErrorMessage = "Your image's filetype is not valid.")]
        public IFormFile ActualImage { get; set; }
    }
}
