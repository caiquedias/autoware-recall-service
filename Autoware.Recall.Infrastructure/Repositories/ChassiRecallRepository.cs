using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoware.Recall.Infrastructure.Repositories
{
    public class ChassiRecallRepository : GenericRepository<ChassiRecall>, IChassiRecallRepository
    {
        IDbContext _dbContext;
        public ChassiRecallRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<ChassiRecall> GetChassiRecall()
        {
            try
            {
                return _dbContext.Set<ChassiRecall>()
                    .AsNoTracking()
                    .Include(x => x.Chassi)
                    .Include(x => x.Recall);
            }
            catch
            {
                throw;
            }
        }

        public IQueryable<ChassiRecall> GetChassiRecallByChassi(string chassi)
        {
            try
            {
                return _dbContext.Set<ChassiRecall>()
                    .AsNoTracking()
                    .Include(x => x.Chassi)
                    .Include(x => x.Recall)
                    .Where(x => x.Chassi.CodigoChassi.Contains(chassi));
            }
            catch
            {
                throw;
            }
        }
    }
}
