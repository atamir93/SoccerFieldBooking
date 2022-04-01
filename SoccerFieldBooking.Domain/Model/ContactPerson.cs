using SoccerFieldBooking.Domain.Common;

namespace SoccerFieldBooking.Domain.Model
{
    public class ContactPerson : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
