using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.RepositoryAndService;

namespace WebApplication2.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TRepository> : ControllerBase
     where TEntity : class, IEntity
     where TRepository : IRepository<TEntity>
    {
        protected readonly TRepository repository;
        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.getAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> Get(int id)
        {
            var ent = await repository.get(id);
            if (ent == null)
            {
                return NotFound();
            }
            return ent;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await repository.update(entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Post(TEntity ent)
        {
            await repository.add(ent);
            return CreatedAtAction("Get", new { id = ent.Id }, ent);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult<TEntity>> Delete(int id)
        {
            var ent = await repository.delete(id);
            if (ent == null)
            {
                return NotFound();
            }
            return ent;
        }

    }
}

