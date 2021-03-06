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
    public sealed class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {

        /// <summary>
        ///     Configure OrderItem.
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            
            builder
            .HasOne<Order>(b => b.Order)
            .WithMany(b => b.OrderItems)
            .HasForeignKey(b => b.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

            builder
           .HasOne<Product>(p => p.Product)
           .WithMany(b => b.OrderItems)
           .HasForeignKey(p => p.ProductId)
           .OnDelete(DeleteBehavior.Cascade);
        }
    }
}