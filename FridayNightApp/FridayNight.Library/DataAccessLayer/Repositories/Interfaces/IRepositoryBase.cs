using FridayNight.Common.Abstract;

namespace FridayNight.DataAccessLayer.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> : IRepositoryReadOnly<TEntity>, IRepositoryWriteOnly<TEntity> where TEntity : IEntity
    {
    }
}
