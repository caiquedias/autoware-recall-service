using Autoware.Recall.Api.Application.Interfaces;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces;
using Autoware.Recall.Infrastructure.Services;

namespace Autoware.Recall.Api.Application.Services
{
    public class RecallApplicationService : GenericApplicationService<Domain.AggregatesModel.RecallAggregate.Models.Recall>, IRecallApplicationService
    {
        private readonly IRecallRepository _repository;
        private readonly IConfiguration _configuration;
        public RecallApplicationService(
            IRecallRepository repository,
            IConfiguration configuration) : base(repository, configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }
    }
}
