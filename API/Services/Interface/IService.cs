using API.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IService<T> where T : class
    {
        Task<List<T>> Get();
        Task<T> Get(string id);
        Task<int> Post(T entity);
        Task<int> Put(T entity);
        Task<int> Delete(string id);
    }
}
