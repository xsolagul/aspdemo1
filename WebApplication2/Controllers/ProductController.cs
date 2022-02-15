using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<Product, EFCoreProductRepository>
    {
        public ProductController(EFCoreProductRepository repository) : base(repository) { }
        [HttpPut("/admin/Product/{id}")]
        public override async Task<IActionResult> Put(int id, Product entity) {
           return   await base.Put(id,entity);
                }
        [HttpGet("findbybrand/{brandId}")]
        public async Task<ActionResult<List<Product>>> FindByBrand(int brandId)
        {
            var product = await repository.findByBrandId(brandId);
            if (!product.Any())
            { return NotFound(); }
            return Ok(product);
        }

        /*private readonly DataContext _Context;
        public ProductController(DataContext context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return Ok(await _Context.Product.ToListAsync());
        }*/
    }
}
