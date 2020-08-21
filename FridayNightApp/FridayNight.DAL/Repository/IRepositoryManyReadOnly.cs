using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryManyReadOnly<TEntity> : IRepositoryReadOnly<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> GetMany(IRepositoryCondition condition = null);
    }
}
