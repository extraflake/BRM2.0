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
    public class TransactionService<TEntity, TService> : ITranscationService<TEntity>
        where TEntity : class
        where TService : ITranscationRepository<TEntity>
    {

        private readonly TransactionRepository<TEntity, MyContext> _transactionRepository;

        public TransactionService(TransactionRepository<TEntity, MyContext> transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Task<List<TEntity>> Get()
        {
            return _transactionRepository.Get();
        }

        public Task<TEntity> Get(int id)
        {
            return _transactionRepository.Get(id);
        }

        public Task<int> Post(TEntity entity)
        {
            return _transactionRepository.Post(entity);
        }

        public Task<int> Put(TEntity entity)
        {
            return _transactionRepository.Put(entity);
        }

        public Task<int> Delete(int id)
        {
            return _transactionRepository.Delete(id);
        }
    }
}
