using SoccerFieldBooking.Domain.Common;
using SoccerFieldBooking.Domain.ValueObjects;

namespace SoccerFieldBooking.Domain.Model
{
    public class Field : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public decimal PricePerHour { get; set; }
        public int Capacity { get; set; }
        public FieldSize Size { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}