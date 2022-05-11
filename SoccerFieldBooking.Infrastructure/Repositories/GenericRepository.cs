using InventoryManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using SoccerFieldBooking.Domain.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SoccerFieldBooking.Infrastructure.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository()
        {
        }
        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public async Task<int> Add(TEntity entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync(CancellationToken.None);
            return entity.Id;
        }

        public async Task Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync(CancellationToken.None);
            }
        }

        public async Task<TEntity> Get(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var list = await _dbSet.ToListAsync();
            return list;
        }

        public Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return _context.SaveChangesAsync(CancellationToken.None);
        }
    }
}
