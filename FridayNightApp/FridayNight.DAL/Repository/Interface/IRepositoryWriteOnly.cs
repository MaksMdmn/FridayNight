using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository.Interface
{
    public interface IRepositoryWriteOnly<TEntity> : IRepository where TEntity : IEntity
    {
        TEntity CreateOrUpdate(TEntity entity);

        void Delete(Guid uid);
    }
}
