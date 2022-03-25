using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.Model;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.HasIndex(p => new { p.Name, p.CompanyId }).IsUnique();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.OwnsOne(p => p.Size);
        }
    }
}
