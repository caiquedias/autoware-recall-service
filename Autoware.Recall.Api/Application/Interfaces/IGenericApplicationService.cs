using Autoware.Recall.Domain;

namespace Autoware.Recall.Api.Application.Interfaces
{
    public interface IGenericApplicationService<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
