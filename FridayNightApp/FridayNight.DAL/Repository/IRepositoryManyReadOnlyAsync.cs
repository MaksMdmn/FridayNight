using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryManyReadOnlyAsync<TEntity> : IRepositoryReadOnlyAsync<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> GetManyAsync(IRepositoryCondition condition = null);
    }
}
