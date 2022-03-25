using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.ValueObjects;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class FieldSizeConfiguration : IEntityTypeConfiguration<FieldSize>
    {
        public void Configure(EntityTypeBuilder<FieldSize> builder)
        {
            builder.Ignore(p => p.Perimeter);
        }
    }
}
