using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryBaseAsync<TEntity> : IRepositoryReadOnlyAsync<TEntity>, IRepositoryWriteOnlyAsync<TEntity> where TEntity : IEntity
    {
    }
}
