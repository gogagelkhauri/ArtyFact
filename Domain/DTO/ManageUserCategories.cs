using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class ManageUserCategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Selected { get; set; }
    }
}
