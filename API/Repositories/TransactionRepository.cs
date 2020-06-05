using API.Context;
using API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class TransactionRepository<TEntity, TContext> : ITranscationRepository<TEntity>
        where TEntity : class
        where TContext : MyContext
    {
        private readonly MyContext _myContext;

        public TransactionRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public async Task<List<TEntity>> Get()
        {
            var result = await _myContext.Set<TEntity>().ToListAsync();
            if (!result.Count().Equals(0))
            {
                return result;
            }
            return null;
        }

        public async Task<TEntity> Get(int id)
        {
            var result = await _myContext.Set<TEntity>().FindAsync(id);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public async Task<int> Post(TEntity entity)
        {
            await _myContext.Set<TEntity>().AddAsync(entity);
            var result = await _myContext.SaveChangesAsync();
            if (result > 0)
            {
                return result;
            }
            return result;
        }

        public async Task<int> Put(TEntity entity)
        {
            _myContext.Entry(entity).State = EntityState.Modified;
            var result = await _myContext.SaveChangesAsync();
            if (result > 0)
            {
                return result;
            }
            return result;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await Get(id);
            if (entity == null)
            {
                return 0;
            }
            _myContext.Set<TEntity>().Remove(entity);
            var result = await _myContext.SaveChangesAsync();
            return result;
        }
    }
}
