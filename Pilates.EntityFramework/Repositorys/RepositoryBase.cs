using Microsoft.EntityFrameworkCore;
using Pilates.EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilates.EntityFramework.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
        }

        public virtual void DeleteById(Guid id)
        {
            var ent = GetById(id);
            _context.Attach(ent);
            _context.Remove(ent);
            _context.SaveChanges();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual void Save(TEntity input)
        {
            _context.Set<TEntity>().Add(input);
            _context.SaveChanges();
        }

        public virtual void Update(TEntity input)
        {
            _context.Entry(input).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
