﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IRepositoryReadOnly<TEntity> : IRepository where TEntity : IEntity
    {
        TEntity GetById(Guid uid);
    }
}
