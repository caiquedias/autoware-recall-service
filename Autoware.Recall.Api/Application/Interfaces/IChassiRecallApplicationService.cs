using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;

namespace Autoware.Recall.Api.Application.Interfaces
{
    public interface IChassiRecallApplicationService : IGenericApplicationService<ChassiRecall>
    {
        IQueryable<ChassiRecall> GetChassiRecall();
        IQueryable<ChassiRecall> GetChassiRecallByChassi(string chassi);
    }
}
