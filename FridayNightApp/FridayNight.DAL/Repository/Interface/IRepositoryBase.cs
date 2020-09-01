using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository.Interface
{
    public interface IRepositoryBase<TEntity> : IRepositoryReadOnly<TEntity>, IRepositoryWriteOnly<TEntity> where TEntity : IEntity
    {
    }
}
