using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;

namespace Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces
{
    public interface IChassiRecallRepository : IGenericRepository<ChassiRecall>
    {
        IQueryable<ChassiRecall> GetChassiRecall();
        IQueryable<ChassiRecall> GetChassiRecallByChassi(string chassi);
    }
}
