using Domain.Entities;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{

    /// <summary>
    ///     Product Configuration.
    /// </summary>
    public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {

        /// <summary>
        ///     Configure Product.
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           //one to one relationship between Product and ProductDetail
            builder
            .HasOne<ProductDetail>(p => p.ProductDetail)
            .WithOne(p => p.Product)
            .HasForeignKey<ProductDetail>(p => p.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

            //One To Many Relationship Between Product and Category
            builder
            .HasOne<Category>(p => p.Category)
            .WithMany(p => p.Products)
            .HasForeignKey(p => p.CategoryId);

            //One To Many Relationship Between Product and Category
            builder
            .HasOne<UserProfile>(p => p.User)
            .WithMany(p => p.Products)
            .HasForeignKey(p => p.UserId);
        }
    }
}