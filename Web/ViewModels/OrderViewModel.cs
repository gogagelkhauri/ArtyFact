using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class OrderViewModel
    {
        [Required]
        public string Address { get; set; }
        [Required]
        public int PostCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}