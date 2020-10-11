using FridayNight.Common.Abstract;
using System;

namespace FridayNight.DataAccessLayer.Repositories.Interfaces
{
    public interface IRepositoryWriteOnly<TEntity> : IRepository where TEntity : IEntity
    {
        TEntity CreateOrUpdate(TEntity entity);

        void Delete(Guid? uid);
    }
}
