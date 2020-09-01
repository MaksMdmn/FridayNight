using FridayNight.DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{

    //
    // TODO: implement Many methods?
    // TODO: implement Result class?
    //
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IEntity
    {
        protected DbContext _context;
        // do we need that shit?
        protected DbSet<TEntity> _entities;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }


        public virtual TEntity CreateOrUpdate(TEntity entity)
        {
            if (entity == null)
            {
                return default;
            }

            TEntity resultEntity = null;

            var oldEntity = _context.Find<TEntity>(entity.Uid);

            if (oldEntity == null)
            {
                resultEntity = _context.Add(entity).Entity;

                _context.SaveChanges();
            }
            else
            {
                _context.Entry(oldEntity).State = EntityState.Detached;
                _context.Entry(entity).State = EntityState.Modified;

                resultEntity = entity;

                _context.SaveChanges();

            }

            return resultEntity;
        }

        public virtual void Delete(Guid uid)
        {
            _context.Remove(_context.Find<TEntity>(uid));

            _context.SaveChanges();
        }

        public virtual TEntity GetById(Guid uid)
        {
            return _context.Find<TEntity>(uid);
        }
    }
}
