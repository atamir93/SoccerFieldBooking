using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.Model;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasIndex(p => p.Phone).IsUnique().HasDatabaseName("UserPhoneIndex");
            builder.Property(p => p.Phone).IsRequired();
        }
    }
}