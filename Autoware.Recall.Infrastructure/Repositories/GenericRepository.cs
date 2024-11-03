using Autoware.Recall.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace Autoware.Recall.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
       where TEntity : class, IEntity
    {

        private IDbContext _dbContext;

        public GenericRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>()
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
