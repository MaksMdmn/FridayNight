using FridayNight.Common.Abstract;
using System;

namespace FridayNight.DataAccessLayer.Repositories.Interfaces
{
    public interface IRepositoryReadOnly<TEntity> : IRepository where TEntity : IEntity
    {
        TEntity GetById(Guid? uid);
    }
}
