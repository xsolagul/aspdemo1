namespace WebApplication2.RepositoryAndService.core
{
    
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
           where TEntity : class ,IEntity
        where TContext : DbContext
    {
        protected readonly TContext context;
        public EfCoreRepository(TContext context)
        {
            this.context = context;
        }
        public async Task<TEntity> add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> delete(int id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> getAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

    }
}

