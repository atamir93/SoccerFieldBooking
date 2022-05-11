using SoccerFieldBooking.Domain.Model;
using SoccerFieldBooking.Domain.Repositories;

namespace SoccerFieldBooking.Infrastructure.Repositories
{
    public class ContactPersonRepository : GenericRepository<ContactPerson>, IContactPersonRepository
    {
    }
}
