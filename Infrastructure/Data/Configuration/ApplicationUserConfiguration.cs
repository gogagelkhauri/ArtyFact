using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{

    /// <summary>
    ///     ApplicationUser Configuration.
    /// </summary>
    public sealed class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {

        /// <summary>
        ///     Configure ApplicationUser.
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            //One To One Relationships between ApplicationUser and UserProfile
            builder.HasOne<UserProfile>(s => s.UserProfile)
                    .WithOne(ad => ad.User)
                    .HasForeignKey<UserProfile>(ad => ad.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            
            //change Identity table name
            builder.ToTable(name: "User");
        }
    }
}