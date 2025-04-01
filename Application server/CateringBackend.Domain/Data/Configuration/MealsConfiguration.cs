using CateringBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CateringBackend.Domain.Data.Configuration
{
    public class MealsConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder
                .ToTable("Meals");
            builder
                .HasMany(x => x.Diets)
                .WithMany(x => x.Meals);
        }
    }
}
