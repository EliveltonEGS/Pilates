﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.EntityFramework.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Save(TEntity input);
        Task<IEnumerable<TEntity>> GetAll();
        void Update(TEntity input);
        void DeleteById(Guid id);
        TEntity GetById(Guid id);
    }
}
