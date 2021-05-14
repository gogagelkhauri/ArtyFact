using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.DTO
{
    public class CategoryDTO 
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }

}