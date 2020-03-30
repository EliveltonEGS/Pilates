using Pilates.EntityFramework.Repositorys;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Service.Services
{
    public class ServiceBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void DeleteById(Guid id)
        {
            _repository.DeleteById(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Save(TEntity input)
        {
            _repository.Save(input);
        }

        public void Update(TEntity input)
        {
            _repository.Update(input);
        }
    }
}
