using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.Model;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(p => p.Phone).IsUnique().HasDatabaseName("UserPhoneIndex");
            builder.Property(p => p.Phone).IsRequired();
        }
    }
}