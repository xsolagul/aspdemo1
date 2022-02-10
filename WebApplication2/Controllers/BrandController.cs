using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.RepositoryAndService.core.CoreWithEntity;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController<Brand, EFCoreBrandRepository>
    {
        public BrandController(EFCoreBrandRepository repository): base(repository) { }
    }
    /*public class BrandController : ControllerBase
    {
        private readonly DataContext _Context;
        public BrandController(DataContext context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Brand>>> Get()
        {
            return Ok(await _Context.Brand.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Brand>>> Get(int id)
        {
            return Ok(await _Context.Brand.FindAsync(id));
        }
        [HttpPost]
        public async Task<ActionResult<List<Brand>>> AddBrand([FromBody] Brand brand)
        {
            _Context.Brand.Add(brand);
            await _Context.SaveChangesAsync();
            return Ok(await _Context.Brand.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Brand>>> Put([FromBody] Brand brand)
        {
            var DbBrand = await _Context.Brand.FindAsync(brand.Id);
            if (DbBrand == null)
            {
                return BadRequest("brand not found");
            }
            DbBrand.name = brand.name;
            await _Context.SaveChangesAsync();
            return Ok(await _Context.Brand.FindAsync(brand.Id));
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Brand>>> delete(int id)
        {
            var DbBrand = await _Context.Brand.FindAsync(id);
            if (DbBrand == null)
            {
                return BadRequest("brand not found");
            }
            _Context.Brand.Remove(DbBrand);
            await _Context.SaveChangesAsync();
            return Ok(await _Context.Brand.ToListAsync());
        }

    }*/
}

