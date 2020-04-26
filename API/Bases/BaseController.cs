using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories.Interface;
using API.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Bases
{
    public class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class
        where TRepository : IService<TEntity>
    {
        private readonly TRepository _repository;

        public BaseController(TRepository repository) { this._repository = repository; }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get() => await _repository.Get();

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(string id)
        {
            var get = await _repository.Get(id);
            if (get == null)
            {
                return NotFound();
            }
            return Ok(get);
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            var post = await _repository.Post(entity);
            return Ok(post);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, TEntity entity)
        {
            await _repository.Put(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> Delete(string id)
        {
            var delete = await _repository.Delete(id);
            if (delete.Equals(0))
            {
                return NotFound();
            }
            return delete;
        }
    }
}