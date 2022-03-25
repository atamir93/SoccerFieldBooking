using SoccerFieldBooking.Domain.Common;
using SoccerFieldBooking.Domain.Enums;
using SoccerFieldBooking.Domain.ValueObjects;

namespace SoccerFieldBooking.Domain.Model.ScheduleAggregate
{
    public class Reservation : Entity
    {
        public string Title { get; set; }
        public int ScheduleId { get; set; }
        public int UserId { get; set; }
        public int FieldId { get; set; }
        public ReservationState State { get; set; }
        public DateTimeRange DateTimeRange { get; set; }
    }
}
