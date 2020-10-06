using FridayNight.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repositories.Abstract
{

    //
    // TODO: implement Many methods?
    // TODO: implement Result class?
    //
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IEntity
    {
        protected DbContext Context;
        // do we need that shit?
        protected DbSet<TEntity> Entities;

        public RepositoryBase(DbContext context)
        {
            Context = context;
            Entities = Context.Set<TEntity>();
        }


        public virtual TEntity CreateOrUpdate(TEntity entity)
        {
            if (entity == null)
            {
                return default;
            }

            TEntity resultEntity = null;

            var oldEntity = Context.Find<TEntity>(entity.Uid);

            if (oldEntity == null)
            {
                resultEntity = Context.Add(entity).Entity;

                Context.SaveChanges();
            }
            else
            {
                Context.Entry(oldEntity).State = EntityState.Detached;
                Context.Entry(entity).State = EntityState.Modified;

                resultEntity = entity;

                Context.SaveChanges();

            }

            return resultEntity;
        }

        public virtual void Delete(Guid? uid)
        {
            Context.Remove(Context.Find<TEntity>(uid));

            Context.SaveChanges();
        }

        public virtual TEntity GetById(Guid? uid)
        {
            return Context.Find<TEntity>(uid);
        }
    }
}
