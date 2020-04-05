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
        where TEntity : class, IEntity
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
            await _repository.Post(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await _repository.Put(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(string id)
        {
            var delete = await _repository.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }
    }
}