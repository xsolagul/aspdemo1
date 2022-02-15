namespace WebApplication2.RepositoryAndService.core.CoreWithEntity
{
    public class EFCoreProductRepository:EfCoreRepository<Product,DataContext>
    {
        public EFCoreProductRepository(DataContext context):base(context) { }
        
        public override async Task<List<Product>> getAll()
        {
            var product = await context.Product.Include(p => p.Brand).ToListAsync();
            return product;

        }
        public override async Task<Product> get(int id)
        {
            var product = await context.Product.Include(p => p.Brand).FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }
        public override async Task<Product> add(Product entity)
        {
            entity.Brand = null;
            return  await base.add(entity);
        }
        public async Task<Product> update(Product entity) 
        { 
            entity.Brand = null; 
            return await base.update(entity);
        }  
        //new Method
        public async Task<List<Product>> findByBrandId(int brandId)
        {
            var product = await context.Product
                                        .Where(p => p.BrandId == brandId)
                                        .Include(p => p.Brand)
                                        .ToListAsync();
            return product;
        }
    }
}
