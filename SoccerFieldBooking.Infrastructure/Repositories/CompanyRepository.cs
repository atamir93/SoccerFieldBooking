using SoccerFieldBooking.Domain.Model;
using SoccerFieldBooking.Domain.Repositories;

namespace SoccerFieldBooking.Infrastructure.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
    }
}
