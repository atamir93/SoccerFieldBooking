using SoccerFieldBooking.Domain.Common;
using SoccerFieldBooking.Domain.ValueObjects;
using System.Collections.Generic;

namespace SoccerFieldBooking.Domain.Model.ScheduleAggregate
{
    public class Schedule : Entity, IAggregateRoot
    {
        public DateTimeRange DateTimeRange { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
