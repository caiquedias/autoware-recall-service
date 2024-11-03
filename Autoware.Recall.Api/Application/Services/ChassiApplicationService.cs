using Autoware.Recall.Api.Application.Interfaces;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;
using Autoware.Recall.Infrastructure.Services;

namespace Autoware.Recall.Api.Application.Services
{
    public class ChassiApplicationService : GenericApplicationService<Chassi>, IChassiApplicationService
    {
        private readonly IChassiRepository _repository;
        private readonly IConfiguration _configuration;
        public ChassiApplicationService(
            IChassiRepository repository,
            IConfiguration configuration) : base(repository, configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }
    }
}
