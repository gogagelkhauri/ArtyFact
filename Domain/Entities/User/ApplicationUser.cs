using Microsoft.AspNetCore.Identity;
using System;


namespace Domain.Entities.User
{
    public class ApplicationUser : IdentityUser
    {
        public UserProfile UserProfile { get; set; }
    }
}
