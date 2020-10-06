using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repositories.Abstract
{
    public interface IRepositoryWriteOnly<TEntity> : IRepository where TEntity : IEntity
    {
        TEntity CreateOrUpdate(TEntity entity);

        void Delete(Guid? uid);
    }
}
