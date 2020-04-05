using API.Bases;
using API.Context;
using API.Repositories;
using API.Repositories.Interface;
using API.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class GeneralService<TEntity, TService> : IService<TEntity>
        where TEntity : class, IEntity
        where TService : IRepository<TEntity>
    {
        private readonly GeneralRepository<TEntity, MyContext> _generalRepository;

        public GeneralService(GeneralRepository<TEntity, MyContext> generalRepository)
        {
            _generalRepository = generalRepository;
        }

        public Task<TEntity> Delete(string id)
        {
            return _generalRepository.Delete(id);
        }

        public Task<List<TEntity>> Get()
        {
            return _generalRepository.Get();
        }

        public Task<TEntity> Get(string id)
        {
            return _generalRepository.Get(id);
        }

        public Task<TEntity> Post(TEntity entity)
        {
            return _generalRepository.Post(entity);
        }

        public Task<TEntity> Put(TEntity entity)
        {
            return _generalRepository.Put(entity);
        }
    }
}
