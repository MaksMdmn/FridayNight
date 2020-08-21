using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryBaseManyAsync<TEntity> : IRepositoryManyReadOnlyAsync<TEntity>, IRepositoryManyWriteOnlyAsync<TEntity> where TEntity : IEntity
    {
    }
}
