using System;
using Domain.Entities.User;

namespace Domain.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
    }
}