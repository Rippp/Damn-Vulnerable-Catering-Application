using CateringBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CateringBackend.Domain.Data.Configuration
{
    public class DietsConfiguration : IEntityTypeConfiguration<Diet>
    {
        public void Configure(EntityTypeBuilder<Diet> builder)
        {
            builder
                .ToTable("Diets");
            builder
                .HasMany(x => x.Meals)
                .WithMany(x => x.Diets);
            builder
                .HasMany(x => x.Orders)
                .WithMany(x => x.Diets);
        }
    }
}
