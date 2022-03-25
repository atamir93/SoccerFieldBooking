using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerFieldBooking.Domain.Model.ScheduleAggregate;

namespace SoccerFieldBooking.Infrastructure.Persistence.EntityConfigurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.OwnsOne(p => p.DateTimeRange);
        }
    }
}
