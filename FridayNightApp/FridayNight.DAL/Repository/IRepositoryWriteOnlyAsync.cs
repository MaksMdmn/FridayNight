using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryWriteOnlyAsync<TEntity> : IRepository where TEntity : IEntity
    {
        Task<TEntity> CreateOrUpdateAsync(TEntity entity);
        Task DeleteAsync(Guid uid);
    }
}
