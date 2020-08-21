using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryManyWriteOnly<TEntity> : IRepositoryWriteOnly<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> CreateOrUpdateMany(IEnumerable<TEntity> entities, IRepositoryCondition condition = null);
        void DeleteMany(IRepositoryCondition condition = null);
    }
}
