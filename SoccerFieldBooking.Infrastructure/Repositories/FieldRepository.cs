using SoccerFieldBooking.Domain.Model;
using SoccerFieldBooking.Domain.Repositories;

namespace SoccerFieldBooking.Infrastructure.Repositories
{
    public class FieldRepository : GenericRepository<Field>, IFieldRepository
    {
    }
}
