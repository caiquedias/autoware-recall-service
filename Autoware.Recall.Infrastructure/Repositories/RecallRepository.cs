using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces;

namespace Autoware.Recall.Infrastructure.Repositories
{
    public class RecallRepository : GenericRepository<Domain.AggregatesModel.RecallAggregate.Models.Recall>, IRecallRepository
    {
        IDbContext _dbContext;
        public RecallRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
