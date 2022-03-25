using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.Model.ScheduleAggregate;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.OwnsOne(p => p.DateTimeRange);
        }
    }
}
