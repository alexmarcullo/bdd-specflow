using Lexx.Bdd.Specflow.Shared.Entities;

namespace Lexx.Bdd.Specflow.Domain.Repositories
{
    public interface IBaseRepository<TEntity, TEntityId> where TEntity : Entity<TEntityId>
    {
        TEntity Get(TEntityId id);

        void Save(TEntity entity);
    }
}
