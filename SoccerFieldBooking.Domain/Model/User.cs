using SoccerFieldBooking.Domain.Common;

namespace SoccerFieldBooking.Domain.Model
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
