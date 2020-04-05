using API.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IService<T> where T : class, IEntity
    {
        Task<List<T>> Get();
        Task<T> Get(string id);
        Task<T> Post(T entity);
        Task<T> Put(T entity);
        Task<T> Delete(string id);
    }
}
