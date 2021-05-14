using Microsoft.AspNetCore.Identity;
using System;


namespace Domain.Entities.User
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
