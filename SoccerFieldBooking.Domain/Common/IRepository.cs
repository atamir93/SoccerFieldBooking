using System.Collections.Generic;

namespace SoccerFieldBooking.Domain.Common
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IEnumerable<T> List();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
