using Domain.Entities;
using Domain.Entities.Basket;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{

    /// <summary>
    ///     BasketItem Configuration.
    /// </summary>
    public sealed class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
    {

        /// <summary>
        ///     Configure BasketItem.
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void Configure(EntityTypeBuilder<BasketItem> builder)
        {
            //One To Many Relationship Between BasketItem and Basket
            builder
            .HasOne<Basket>(b => b.Basket)
            .WithMany(b => b.BasketItems)
            .HasForeignKey(b => b.BasketId)
            .OnDelete(DeleteBehavior.Cascade);

            //One To One Relationships between BasketItem and Product
            builder
            .HasOne<Product>(p => p.Product)
            .WithMany(b => b.BasketItems)
            .HasForeignKey(p => p.ProductId);

            builder.Property(i => i.Price)
            .IsRequired(true)
            .HasColumnType("decimal(18,2)");
                


        }
    }
}