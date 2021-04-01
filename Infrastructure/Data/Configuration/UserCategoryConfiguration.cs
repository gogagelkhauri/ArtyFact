using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{

    /// <summary>
    ///     UserCategory Configuration.
    /// </summary>
    public sealed class UserCategoryConfiguration : IEntityTypeConfiguration<UserCategory>
    {

        /// <summary>
        ///     Configure UserCategory.Many To Many Relationship between UserProfile And Category
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void Configure(EntityTypeBuilder<UserCategory> builder)
        {
            builder.HasKey(uc => new { uc.UserId, uc.CategoryId }); 

            builder.HasOne(c => c.User)
                    .WithMany(c => c.UserCategories)
                    .HasForeignKey(c => c.UserId)
                    .OnDelete(DeleteBehavior.Cascade);  

            builder.HasOne(c => c.Category)
                .WithMany(c => c.UserCategories)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}