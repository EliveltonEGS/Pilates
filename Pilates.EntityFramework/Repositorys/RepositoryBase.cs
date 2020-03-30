using Microsoft.EntityFrameworkCore;
using Pilates.EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pilates.EntityFramework.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
        }

        public void DeleteById(Guid id)
        {
            var ent = GetById(id);
            _context.Attach(ent);
            _context.Remove(ent);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Save(TEntity input)
        {
            _context.Set<TEntity>().Add(input);
            _context.SaveChanges();
        }

        public void Update(TEntity input)
        {
            _context.Entry(input).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
