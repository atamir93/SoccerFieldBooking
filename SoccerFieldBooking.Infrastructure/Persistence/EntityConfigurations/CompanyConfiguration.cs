using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.Model;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasIndex(p => p.Name).IsUnique().HasDatabaseName("NameIndex");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);

            builder.Property(p => p.CreatedDate).HasDefaultValueSql("getdate()");
            builder.OwnsOne(p => p.Address);
        }
    }
}
