namespace WebApplication2.RepositoryAndService.core.CoreWithEntity
{
    public class EFCoreBrandRepository: EfCoreRepository<Brand,DataContext>
    {
        public EFCoreBrandRepository(DataContext context) :base(context)
            { 
        
        }
        // We can add new methods specific to the branb repository here in the future
/*        public override async Task<> add(Brand entity)
        {
            context.Set<Brand>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }*/
    }
}
