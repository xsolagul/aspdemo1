using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication2.RepositoryAndService.core.CoreWithEntity
{
    public class EFCoreBrandRepository: EfCoreRepository<Brand,DataContext>
    {
        public EFCoreBrandRepository(DataContext context) :base(context)
            { 

        }
        // We can add new methods specific to the branb repository here in the future
        public override async Task<List<Brand>> getAll()
        {
            var brand = await context.Brand.Include(b => b.Products).ToListAsync();
            return brand;

        }


     
    }
}
