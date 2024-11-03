using Autoware.Recall.Api.Application.Interfaces;
using Autoware.Recall.Domain;

namespace Autoware.Recall.Infrastructure.Services
{
    public class GenericApplicationService<TEntity> :
    IGenericApplicationService<TEntity>
    where TEntity : class, IEntity
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IConfiguration _configuration;

        public GenericApplicationService(
            IGenericRepository<TEntity> repository,
            IConfiguration configuration)
        {
            _configuration = configuration;
            _repository = repository;
        }

        public IQueryable<TEntity> GetAll()
        {
            var results = _repository.GetAll();

            return results;
        }

        public TEntity GetById(int id)
        {
            var result = _repository.GetById(id).Result;

            return result;
        }
    }
}
