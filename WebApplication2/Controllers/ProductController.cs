using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _Context;
        public ProductController(DataContext context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return Ok(await _Context.product.ToListAsync());
        }
    }
}
