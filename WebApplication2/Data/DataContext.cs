using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public class DataContext : DbContext
    {   
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : 
            base(options)//pass on the base class of dbcontext
        {

        }
/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandId);
        }*/

    }
}
