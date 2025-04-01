using CateringBackend.Domain.Entities;
using CateringBackend.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CateringBackend.Domain.Data.Configuration
{
    public class ComplaintsConfiguration : IEntityTypeConfiguration<Complaint>
    {
        public void Configure(EntityTypeBuilder<Complaint> builder)
        {
            builder
                .ToTable("Complaints");
            builder
                .HasOne(x => x.Order)
                .WithMany(x => x.Complaints)
                .HasForeignKey(x => x.OrderId);
            builder
                .Property(x => x.Status)
                .HasConversion(new EnumToStringConverter<ComplaintStatus>());
        }
    }
}
