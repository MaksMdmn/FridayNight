using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryBaseMany<TEntity> : IRepositoryManyReadOnly<TEntity>, IRepositoryManyWriteOnly<TEntity> where TEntity : IEntity 
    {
    }
}
