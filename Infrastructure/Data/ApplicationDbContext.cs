using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.User;
using Domain.Entities;
using Infrastructure.Data.Configuration;
using Domain.Entities.Basket;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //builder.Entity<ApplicationUser>();
            //builder.HasDefaultSchema("Identity");

            //change Identity table Default names
            builder.ChangeIdentityTableDefaultNames();

            builder.Entity<Order>()
            .HasOne<UserProfile>(b => b.User)
            .WithMany(b => b.Orders)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Restrict);
            

            //One To Many Relationship Between ProductDetail and PaintType
            builder.Entity<Post>()
            .HasOne<UserProfile>(p => p.User)
            .WithMany(p => p.Posts)
            .HasForeignKey(p => p.UserId);

            //one to one between userprofile and basket
            builder.Entity<UserProfile>()
                .HasOne<Basket>(s => s.Basket)
                .WithOne(ad => ad.User)
                .HasForeignKey<Basket>(ad => ad.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
