using Autoware.Recall.Api.Application.Interfaces;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;
using Autoware.Recall.Infrastructure.Services;

namespace Autoware.Recall.Api.Application.Services
{
    public class ChassiRecallApplicationService : GenericApplicationService<ChassiRecall>, IChassiRecallApplicationService
    {
        private readonly IChassiRecallRepository _repository;
        private readonly IConfiguration _configuration;
        public ChassiRecallApplicationService(
            IChassiRecallRepository repository,
            IConfiguration configuration) : base(repository, configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        public IQueryable<ChassiRecall> GetChassiRecall()
        {
            try
            {
                return _repository.GetChassiRecall();
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
                return _repository.GetChassiRecallByChassi(chassi);
            }
            catch
            {
                throw;
            }
        }
    }
}
