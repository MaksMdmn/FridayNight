using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryManyWriteOnlyAsync<TEntity> : IRepositoryWriteOnlyAsync<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> CreateOrUpdateManyAsync(IEnumerable<TEntity> entities, IRepositoryCondition condition = null);
        Task DeleteManyAsync(IRepositoryCondition condition = null);
    }
}
