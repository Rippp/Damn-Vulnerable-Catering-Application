using CateringBackend.Domain.Entities;
using CateringBackend.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CateringBackend.Domain.Data.Configuration
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .ToTable("Orders");
            builder
                .HasOne(x => x.Client)
                .WithMany()
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(x => x.DeliveryAddress)
                .WithMany()
                .HasForeignKey(x => x.DeliveryAddressId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(x => x.Diets)
                .WithMany(x => x.Orders);
            builder
                .Property(x => x.Status)
                .HasConversion(new EnumToStringConverter<OrderStatus>());
        }
    }
}
