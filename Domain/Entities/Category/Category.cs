using System.Collections.Generic;

namespace Domain.Entities
{

    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public List<UserCategory> UserCategories { get; set; }
        public List<Product> Products { get; set; }
    }

}