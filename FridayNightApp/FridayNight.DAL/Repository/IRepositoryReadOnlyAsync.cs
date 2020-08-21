using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryReadOnlyAsync<TEntity> : IRepository where TEntity : IEntity
    {
        Task<TEntity> GetAsync(Guid uid);
    }
}
