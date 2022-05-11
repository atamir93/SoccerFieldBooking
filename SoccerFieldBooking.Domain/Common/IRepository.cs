using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoccerFieldBooking.Domain.Common
{
    public interface IRepository<T> where T : Entity
    {
        Task<int> Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
