using Microsoft.EntityFrameworkCore;

namespace Autoware.Recall.Infrastructure.Repositories
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();

        void Dispose();
    }
}
