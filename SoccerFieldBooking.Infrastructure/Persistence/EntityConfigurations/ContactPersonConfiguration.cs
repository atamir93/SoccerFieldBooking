using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.Model;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class ContactPersonConfiguration : IEntityTypeConfiguration<ContactPerson>
    {
        public void Configure(EntityTypeBuilder<ContactPerson> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Phone).IsRequired();
            builder.HasOne(p => p.Company).WithOne(p => p.ContactPerson).HasForeignKey<ContactPerson>(p => p.CompanyId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}