using System.Collections.Generic;

namespace Domain.Entities
{

    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<UserCategory> UserCategories { get; set; }
    }

}